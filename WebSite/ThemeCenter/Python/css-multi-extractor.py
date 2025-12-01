#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Multi-File CSS Class Extractor System
يستخرج الكلاسات من ملفات CSS المتعددة ويقسمها إلى ملفات JSON منفصلة
Extracts CSS classes from multiple files and splits them into separate JSON files
"""

import re
import json
import os
from datetime import datetime
from collections import defaultdict

class MultiFileCSSExtractor:
    def __init__(self):
        self.all_classes = set()
        self.all_ids = set()
        self.all_elements = set()
        self.files_data = {}
        self.theme_groups = {}
        
    def clean_selector(self, selector):
        """تنظيف المحدد من الرموز الإضافية"""
        # إزالة pseudo-classes والحالات الخاصة
        selector = re.sub(r':(hover|active|focus|visited|link|before|after|first-child|last-child|nth-child\([^)]*\))', '', selector)
        # إزالة المسافات الزائدة
        selector = selector.strip()
        return selector
        
    def extract_from_content(self, content, filename):
        """استخراج الكلاسات والمحددات من محتوى CSS"""
        # إزالة التعليقات
        content = re.sub(r'/\*.*?\*/', '', content, flags=re.DOTALL)
        
        # البحث عن جميع المحددات
        selectors = re.findall(r'([^{}]+)\s*{[^{}]*}', content, re.MULTILINE)
        
        file_classes = set()
        file_ids = set()
        file_elements = set()
        
        for selector_group in selectors:
            # تقسيم المحددات المتعددة (مفصولة بفاصلة)
            individual_selectors = [s.strip() for s in selector_group.split(',')]
            
            for selector in individual_selectors:
                selector = self.clean_selector(selector)
                if not selector:
                    continue
                    
                # استخراج الكلاسات (.class)
                classes = re.findall(r'\.([a-zA-Z_][a-zA-Z0-9_-]*)', selector)
                for cls in classes:
                    self.all_classes.add(cls)
                    file_classes.add(cls)
                
                # استخراج IDs (#id)
                ids = re.findall(r'#([a-zA-Z_][a-zA-Z0-9_-]*)', selector)
                for id_name in ids:
                    self.all_ids.add(id_name)
                    file_ids.add(id_name)
                
                # استخراج عناصر HTML
                elements = re.findall(r'^([a-zA-Z][a-zA-Z0-9]*)', selector)
                for element in elements:
                    if element not in ['div', 'span', 'a', 'p', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6']:
                        self.all_elements.add(element)
                        file_elements.add(element)
        
        return {
            'classes': list(file_classes),
            'ids': list(file_ids),
            'elements': list(file_elements),
            'total_selectors': len(selectors)
        }
    
    def process_css_file(self, filepath):
        """معالجة ملف CSS واحد"""
        try:
            with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
                content = f.read()
            
            filename = os.path.basename(filepath)
            file_data = self.extract_from_content(content, filename)
            
            # إضافة معلومات إضافية
            file_data.update({
                'file_path': filepath,
                'file_size': os.path.getsize(filepath),
                'last_modified': datetime.fromtimestamp(os.path.getmtime(filepath)).isoformat()
            })
            
            self.files_data[filename] = file_data
            return True
            
        except Exception as e:
            print(f"خطأ في معالجة الملف {filepath}: {e}")
            return False
    
    def group_classes_by_type(self):
        """تجميع الكلاسات حسب النوع والغرض"""
        groups = {
            'layout': set(),
            'components': set(),
            'utilities': set(),
            'states': set(),
            'themes': set(),
            'responsive': set(),
            'navigation': set(),
            'forms': set(),
            'data_views': set(),
            'membership': set(),
            'core': set(),
            'misc': set()
        }
        
        # قواعد التجميع
        grouping_rules = {
            'layout': ['page', 'header', 'footer', 'sidebar', 'content', 'container', 'wrapper', 'body'],
            'components': ['button', 'btn', 'card', 'modal', 'dialog', 'popup', 'panel', 'box'],
            'utilities': ['hidden', 'visible', 'center', 'left', 'right', 'clear', 'float', 'text'],
            'states': ['active', 'disabled', 'selected', 'hover', 'focus', 'error', 'success'],
            'themes': ['citrus', 'theme', 'color', 'style'],
            'responsive': ['mobile', 'tablet', 'desktop', 'sm', 'md', 'lg', 'xl'],
            'navigation': ['menu', 'nav', 'link', 'breadcrumb', 'tab'],
            'forms': ['form', 'input', 'field', 'label', 'validation', 'login'],
            'data_views': ['table', 'grid', 'list', 'data', 'view', 'row', 'cell'],
            'membership': ['member', 'user', 'auth', 'login', 'register'],
            'core': ['core', 'base', 'main', 'primary']
        }
        
        for class_name in self.all_classes:
            class_lower = class_name.lower()
            assigned = False
            
            for group, keywords in grouping_rules.items():
                if any(keyword in class_lower for keyword in keywords):
                    groups[group].add(class_name)
                    assigned = True
                    break
            
            if not assigned:
                groups['misc'].add(class_name)
        
        # تحويل إلى قوائم مرتبة
        return {group: sorted(list(classes)) for group, classes in groups.items()}
    
    def generate_master_index(self):
        """إنشاء فهرس رئيسي لجميع الملفات"""
        return {
            'generated_at': datetime.now().isoformat(),
            'total_files_processed': len(self.files_data),
            'total_classes': len(self.all_classes),
            'total_ids': len(self.all_ids),
            'total_elements': len(self.all_elements),
            'files_summary': {
                filename: {
                    'classes_count': len(data['classes']),
                    'ids_count': len(data['ids']),
                    'file_size': data['file_size'],
                    'last_modified': data['last_modified']
                } for filename, data in self.files_data.items()
            },
            'output_files': [
                'css-master-index.json',
                'css-classes-by-type.json',
                'css-all-classes.json',
                'css-ids-elements.json',
                'css-files-details.json',
                'css-reset-complete.css',
                'css-modern-variables.css'
            ]
        }
    
    def save_to_multiple_files(self):
        """حفظ البيانات في ملفات JSON متعددة"""
        
        # 1. الفهرس الرئيسي
        master_index = self.generate_master_index()
        with open('css-master-index.json', 'w', encoding='utf-8') as f:
            json.dump(master_index, f, ensure_ascii=False, indent=2)
        
        # 2. الكلاسات مجمعة حسب النوع
        classes_by_type = self.group_classes_by_type()
        with open('css-classes-by-type.json', 'w', encoding='utf-8') as f:
            json.dump(classes_by_type, f, ensure_ascii=False, indent=2)
        
        # 3. جميع الكلاسات (قائمة مرتبة)
        all_classes_data = {
            'all_classes': sorted(list(self.all_classes)),
            'total_count': len(self.all_classes),
            'alphabetical_index': self.create_alphabetical_index(self.all_classes)
        }
        with open('css-all-classes.json', 'w', encoding='utf-8') as f:
            json.dump(all_classes_data, f, ensure_ascii=False, indent=2)
        
        # 4. IDs والعناصر
        ids_elements_data = {
            'ids': sorted(list(self.all_ids)),
            'elements': sorted(list(self.all_elements)),
            'ids_count': len(self.all_ids),
            'elements_count': len(self.all_elements)
        }
        with open('css-ids-elements.json', 'w', encoding='utf-8') as f:
            json.dump(ids_elements_data, f, ensure_ascii=False, indent=2)
        
        # 5. تفاصيل الملفات
        with open('css-files-details.json', 'w', encoding='utf-8') as f:
            json.dump(self.files_data, f, ensure_ascii=False, indent=2)
        
        print("✅ تم إنشاء الملفات التالية:")
        for filename in master_index['output_files']:
            if filename.endswith('.json'):
                print(f"   📄 {filename}")
    
    def create_alphabetical_index(self, classes):
        """إنشاء فهرس أبجدي للكلاسات"""
        index = defaultdict(list)
        for class_name in sorted(classes):
            first_letter = class_name[0].upper()
            index[first_letter].append(class_name)
        return dict(index)
    
    def generate_complete_reset_css(self):
        """إنشاء ملف CSS Reset شامل"""
        reset_css = """/*
=================================================
CSS Reset System - Generated automatically
نظام إعادة تعيين CSS - تم إنشاؤه تلقائياً
=================================================
Generated at: """ + datetime.now().strftime("%Y-%m-%d %H:%M:%S") + """
Total classes: """ + str(len(self.all_classes)) + """
=================================================
*/

/* Global Reset */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html, body {
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, sans-serif;
    line-height: 1.6;
    color: #333;
    background: #fff;
}

/* Classes Reset */
"""
        
        # تجميع الكلاسات حسب النوع
        grouped_classes = self.group_classes_by_type()
        
        for group_name, classes in grouped_classes.items():
            if classes:
                reset_css += f"\n/* {group_name.title()} Classes */\n"
                for class_name in classes:
                    reset_css += f".{class_name} {{\n    /* Reset for {class_name} */\n    position: relative;\n}}\n\n"
        
        # IDs Reset
        if self.all_ids:
            reset_css += "\n/* IDs Reset */\n"
            for id_name in sorted(self.all_ids):
                reset_css += f"#{id_name} {{\n    /* Reset for {id_name} */\n    position: relative;\n}}\n\n"
        
        with open('css-reset-complete.css', 'w', encoding='utf-8') as f:
            f.write(reset_css)
        
        print("✅ تم إنشاء ملف CSS Reset الشامل: css-reset-complete.css")
    
    def generate_modern_variables_css(self):
        """إنشاء ملف متغيرات CSS حديث"""
        variables_css = """/*
=================================================
Modern CSS Variables System
نظام متغيرات CSS الحديث
=================================================
Generated at: """ + datetime.now().strftime("%Y-%m-%d %H:%M:%S") + """
=================================================
*/

:root {
    /* Color Palette */
    --primary-color: #007bff;
    --secondary-color: #6c757d;
    --success-color: #28a745;
    --danger-color: #dc3545;
    --warning-color: #ffc107;
    --info-color: #17a2b8;
    --light-color: #f8f9fa;
    --dark-color: #343a40;
    
    /* Background Colors */
    --bg-primary: #ffffff;
    --bg-secondary: #f8f9fa;
    --bg-dark: #343a40;
    --bg-light: #ffffff;
    
    /* Text Colors */
    --text-primary: #333333;
    --text-secondary: #6c757d;
    --text-muted: #888888;
    --text-light: #ffffff;
    
    /* Spacing */
    --spacing-xs: 0.25rem;
    --spacing-sm: 0.5rem;
    --spacing-md: 1rem;
    --spacing-lg: 1.5rem;
    --spacing-xl: 3rem;
    
    /* Typography */
    --font-family-primary: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, sans-serif;
    --font-family-secondary: Georgia, 'Times New Roman', serif;
    --font-size-xs: 0.75rem;
    --font-size-sm: 0.875rem;
    --font-size-md: 1rem;
    --font-size-lg: 1.25rem;
    --font-size-xl: 1.5rem;
    
    /* Border Radius */
    --border-radius-sm: 0.25rem;
    --border-radius-md: 0.375rem;
    --border-radius-lg: 0.5rem;
    --border-radius-xl: 1rem;
    
    /* Shadows */
    --shadow-sm: 0 1px 3px rgba(0, 0, 0, 0.12);
    --shadow-md: 0 4px 6px rgba(0, 0, 0, 0.15);
    --shadow-lg: 0 10px 25px rgba(0, 0, 0, 0.2);
    
    /* Transitions */
    --transition-fast: 0.15s ease-in-out;
    --transition-normal: 0.3s ease-in-out;
    --transition-slow: 0.5s ease-in-out;
}

/* Modern Utility Classes */
.container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0 var(--spacing-md);
}

.flex {
    display: flex;
}

.flex-column {
    flex-direction: column;
}

.justify-center {
    justify-content: center;
}

.items-center {
    align-items: center;
}

.text-center {
    text-align: center;
}

.mt-1 { margin-top: var(--spacing-xs); }
.mt-2 { margin-top: var(--spacing-sm); }
.mt-3 { margin-top: var(--spacing-md); }
.mt-4 { margin-top: var(--spacing-lg); }
.mt-5 { margin-top: var(--spacing-xl); }

.mb-1 { margin-bottom: var(--spacing-xs); }
.mb-2 { margin-bottom: var(--spacing-sm); }
.mb-3 { margin-bottom: var(--spacing-md); }
.mb-4 { margin-bottom: var(--spacing-lg); }
.mb-5 { margin-bottom: var(--spacing-xl); }

.p-1 { padding: var(--spacing-xs); }
.p-2 { padding: var(--spacing-sm); }
.p-3 { padding: var(--spacing-md); }
.p-4 { padding: var(--spacing-lg); }
.p-5 { padding: var(--spacing-xl); }

/* Modern Component Base Classes */
.btn {
    display: inline-block;
    padding: var(--spacing-sm) var(--spacing-md);
    background: var(--primary-color);
    color: var(--text-light);
    text-decoration: none;
    border: none;
    border-radius: var(--border-radius-md);
    cursor: pointer;
    transition: var(--transition-normal);
    font-family: var(--font-family-primary);
}

.btn:hover {
    transform: translateY(-1px);
    box-shadow: var(--shadow-md);
}

.card {
    background: var(--bg-primary);
    border-radius: var(--border-radius-lg);
    box-shadow: var(--shadow-sm);
    overflow: hidden;
    transition: var(--transition-normal);
}

.card:hover {
    box-shadow: var(--shadow-md);
    transform: translateY(-2px);
}
"""
        
        with open('css-modern-variables.css', 'w', encoding='utf-8') as f:
            f.write(variables_css)
        
        print("✅ تم إنشاء ملف متغيرات CSS الحديث: css-modern-variables.css")

def main():
    print("🚀 بدء نظام استخراج CSS المتقدم...")
    print("="*50)
    
    extractor = MultiFileCSSExtractor()
    
    # قائمة الملفات المراد معالجتها
    css_files = [
        "App_Themes/Citrus/Citrus.css",
        "App_Themes/_Shared/Core.css",
        "App_Themes/_Shared/_Layout.css", 
        "App_Themes/_Shared/Membership.css",
        "App_Themes/eZee/StyleSheet.css"
    ]
    
    print("📁 معالجة الملفات...")
    processed_count = 0
    
    for file_path in css_files:
        if os.path.exists(file_path):
            print(f"   🔄 معالجة: {file_path}")
            if extractor.process_css_file(file_path):
                processed_count += 1
                print(f"   ✅ تم بنجاح")
            else:
                print(f"   ❌ فشل")
        else:
            print(f"   ⚠️ الملف غير موجود: {file_path}")
    
    print(f"\n📊 النتائج الإجمالية:")
    print(f"   📁 الملفات المعالجة: {processed_count}")
    print(f"   🎨 إجمالي الكلاسات: {len(extractor.all_classes)}")
    print(f"   🆔 إجمالي IDs: {len(extractor.all_ids)}")
    print(f"   📝 إجمالي العناصر: {len(extractor.all_elements)}")
    
    print(f"\n💾 حفظ البيانات في ملفات متعددة...")
    extractor.save_to_multiple_files()
    
    print(f"\n🎨 إنشاء ملفات CSS...")
    extractor.generate_complete_reset_css()
    extractor.generate_modern_variables_css()
    
    print("\n🎉 تم الانتهاء من جميع العمليات بنجاح!")
    print("="*50)
    
    # عرض إحصائيات سريعة
    grouped = extractor.group_classes_by_type()
    print("\n📋 توزيع الكلاسات حسب النوع:")
    for group, classes in grouped.items():
        if classes:
            print(f"   {group}: {len(classes)} كلاس")

if __name__ == "__main__":
    main()
