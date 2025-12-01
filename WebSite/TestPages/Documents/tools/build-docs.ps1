param(
  [string]$DocsRoot = "..\..\..\docs",
  [string]$OutRoot = "..\docs-html",
  [string]$SearchOut = "..\assets\search.json"
)

# Normalize to absolute paths relative to this script
$DocsRoot = Resolve-Path -LiteralPath (Join-Path $PSScriptRoot $DocsRoot)
$OutRoot = Join-Path $PSScriptRoot $OutRoot
$SearchOut = Join-Path $PSScriptRoot $SearchOut

# Ensure output dirs
New-Item -ItemType Directory -Path $OutRoot -Force | Out-Null
New-Item -ItemType Directory -Path (Split-Path $SearchOut -Parent) -Force | Out-Null

# Simple markdown to HTML converter (headings, lists, code, links, inline code)
function Convert-MarkdownToHtml {
  param([string]$Md)
  $md = $Md -replace "\r\n","`n"
  $lines = $md -split "`n"
  $sb = New-Object System.Text.StringBuilder
  $inCode = $false; $inUl=$false; $inOl=$false; $para=""
  function EscapeHtml([string]$s){ $s -replace '&','&amp;' -replace '<','&lt;' -replace '>','&gt;' }
  function FlushPara(){ if([string]::IsNullOrEmpty($script:para) -eq $false){ [void]$sb.AppendLine('<p>'+ $script:para.Trim() +'</p>'); $script:para='' } }
  function CloseLists(){ if($script:inUl){ [void]$sb.AppendLine('</ul>'); $script:inUl=$false } if($script:inOl){ [void]$sb.AppendLine('</ol>'); $script:inOl=$false } }
  foreach($raw in $lines){
    $line = $raw -replace "\t","    "
    if($line -match '^```'){ if(-not $inCode){ FlushPara; CloseLists; $inCode=$true; [void]$sb.AppendLine('<pre><code>') } else { $inCode=$false; [void]$sb.AppendLine('</code></pre>') }; continue }
    if($inCode){ [void]$sb.AppendLine((EscapeHtml $raw)); continue }
    if($line -match '^\s*$'){ FlushPara; CloseLists; continue }
    if($line -match '^######\s+(.*)'){ FlushPara; CloseLists; [void]$sb.AppendLine('<h6>'+ $Matches[1] +'</h6>'); continue }
    if($line -match '^#####\s+(.*)'){ FlushPara; CloseLists; [void]$sb.AppendLine('<h5>'+ $Matches[1] +'</h5>'); continue }
    if($line -match '^####\s+(.*)'){ FlushPara; CloseLists; [void]$sb.AppendLine('<h4>'+ $Matches[1] +'</h4>'); continue }
    if($line -match '^###\s+(.*)'){
      FlushPara; CloseLists;
      $h3 = $Matches[1]
      $id = ''
      if($h3 -match '^Function:\s+([A-Za-z0-9_]+)'){
        $fname = $Matches[1]
        $id = ' id="function-' + $fname + '"'
      }
      [void]$sb.AppendLine('<h3'+$id+'>'+ $h3 +'</h3>'); continue }
    if($line -match '^##\s+(.*)'){ FlushPara; CloseLists; [void]$sb.AppendLine('<h2>'+ $Matches[1] +'</h2>'); continue }
    if($line -match '^#\s+(.*)'){ FlushPara; CloseLists; [void]$sb.AppendLine('<h1>'+ $Matches[1] +'</h1>'); continue }
    if($line -match '^\s*[-*]\s+(.*)'){ FlushPara; if($inOl){ [void]$sb.AppendLine('</ol>'); $inOl=$false } if(-not $inUl){ [void]$sb.AppendLine('<ul>'); $inUl=$true } [void]$sb.AppendLine('<li>'+ $Matches[1] +'</li>'); continue }
    if($line -match '^\s*\d+\.\s+(.*)'){ FlushPara; if($inUl){ [void]$sb.AppendLine('</ul>'); $inUl=$false } if(-not $inOl){ [void]$sb.AppendLine('<ol>'); $inOl=$true } [void]$sb.AppendLine('<li>'+ $Matches[1] +'</li>'); continue }
    # paragraph accumulation with inline code and links
    $esc = EscapeHtml $raw
    # inline code
    $esc = [regex]::Replace($esc, '`([^`]+)`', '<code>$1</code>')
    # links with .md -> .html rewrite for relative links
    $pattern = '\\[([^\\]]+)\\]\\(([^)]+)\\)'
    try {
      $esc = [System.Text.RegularExpressions.Regex]::Replace($esc, $pattern, { param($m)
        $text = $m.Groups[1].Value; $url = $m.Groups[2].Value
        $isAbs = ($url -match '^[a-zA-Z]+:') -or ($url -like '#*')
        if(-not $isAbs -and $url -match '\\.md($|#)'){
          if($url -match '^(.*)\\.md(#.*)?$'){
            $base = $Matches[1]; $frag = $Matches[2]
            if(-not $frag){ $frag='' }
            $url = ("{0}.html{1}" -f $base,$frag)
          }
        }
        return ('<a href="{0}" target="_blank" rel="noopener">{1}</a>' -f $url,$text)
      })
    } catch {
      # fallback: leave $esc unchanged
    }
    if($para){ $para += ' ' }
    $para += $esc
  }
  if($inCode){ [void]$sb.AppendLine('</code></pre>') }
  FlushPara; CloseLists
  return $sb.ToString()
}

# Wrap doc HTML with banner and basic page structure
function Wrap-DocHtml {
  param([string]$Path,[string]$Body)
  $crumbs = ($Path -replace '\\','/') -split '/' -join ' › '
  $leaf = Split-Path -Leaf $Path
  @"
<div class="doc-banner">
  <span class="crumbs">$crumbs</span>
  <a class="source" href="$($leaf).md.txt" target="_blank" rel="noopener">View source (.md)</a>
</div>
<div class="doc-body">
$Body
</div>
"@
}

# Build list of markdown files
$mdFiles = Get-ChildItem -Path $DocsRoot -Recurse -Filter *.md

# For search index
$index = @()

foreach($file in $mdFiles){
  $rel = ($file.FullName).Substring((Resolve-Path $DocsRoot).Path.Length).TrimStart('\\')
  # compute rel path without extension without leaving a trailing dot
  $dir = [System.IO.Path]::GetDirectoryName($rel)
  $stem = [System.IO.Path]::GetFileNameWithoutExtension($rel)
  if([string]::IsNullOrEmpty($dir)) { $relNoExt = $stem } else { $relNoExt = (Join-Path $dir $stem) }
  $outPath = Join-Path $OutRoot ($relNoExt + '.html')
  $outDir = Split-Path $outPath -Parent
  New-Item -ItemType Directory -Path $outDir -Force | Out-Null
  $md = Get-Content -LiteralPath $file.FullName -Raw
  $html = Convert-MarkdownToHtml -Md $md
  $wrapped = Wrap-DocHtml -Path ($relNoExt -replace '\\','/') -Body $html
  $wrapped | Out-File -LiteralPath $outPath -Encoding UTF8
  # Write raw markdown copy as .md.txt next to HTML
  $rawOutPath = Join-Path $OutRoot ($rel + '.txt')
  New-Item -ItemType Directory -Path (Split-Path $rawOutPath -Parent) -Force | Out-Null
  $md | Out-File -LiteralPath $rawOutPath -Encoding UTF8

  # Minimal title and snippet for search
  $h1 = ($md -split "`n" | Where-Object { $_ -match '^#\s+' } | Select-Object -First 1)
  if(-not $h1){ $title = [System.IO.Path]::GetFileNameWithoutExtension($file.Name) } else { $title = ($h1 -replace '^#\s+','').Trim() }
  $snippet = ($md -replace '(?s)```.*?```','' -replace '\s+',' ')
  if($snippet.Length -gt 200){ $snippet = $snippet.Substring(0,200) }
  $index += [pscustomobject]@{ title=$title; path=($rel -replace '\\','/'); text=$snippet }

  # Per-function entries for search (anchor support via ?anchor=)
  $funcMatches = [System.Text.RegularExpressions.Regex]::Matches($md, '^###\s+Function:\s+([A-Za-z0-9_]+)', [System.Text.RegularExpressions.RegexOptions]::Multiline)
  foreach($m in $funcMatches){
    $fname = $m.Groups[1].Value
    $index += [pscustomobject]@{
      title = ("Function: {0} - {1}" -f $fname, $stem)
      path  = ( ($rel -replace '\\','/') + ("?anchor=function-{0}" -f $fname) )
      text  = ("Function {0} in {1}" -f $fname, $stem)
    }
  }
}

# Write search index
$index | ConvertTo-Json -Depth 3 | Out-File -LiteralPath $SearchOut -Encoding UTF8

Write-Host "Built $($mdFiles.Count) documents and search index." -ForegroundColor Green
