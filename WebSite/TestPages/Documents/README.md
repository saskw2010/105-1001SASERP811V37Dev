# Documentation Viewer

Use tools/build-docs.ps1 to generate HTML mirrors of all Markdown files under /docs.

Usage (from TestPages/Documents):

```
PowerShell> .\tools\build-docs.ps1
```

This will:
- Convert /docs/**/*.md to /TestPages/Documents/docs-html/**/*.html
- Wrap with a banner and breadcrumbs
- Create assets/search.json for quick searching

Then open TestPages/Documents/index.html in a browser.
