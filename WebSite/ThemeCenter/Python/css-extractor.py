#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
🎨 CSS Classes Extractor & Analyzer
استخراج وتحليل جميع الكلاسات من ملفات CSS لنظام الثيمات
"""

import re
import json
import os
from collections import defaultdict, OrderedDict
from pathlib import Path

class CSSClassExtractor:
    def __init__(self):
        self.classes_data = defaultdict(list)
        self.selectors_data = defaultdict(dict)
        self.theme_structure = {}
        
    def extract_css_selectors(self, css_content, source_file=""):
        """استخراج جميع المحددات من CSS"""
        
        # إزالة التعليقات
        css_content = re.sub(r'/\*.*?\*/', '', css_content, flags=re.DOTALL)
        
        # استخراج جميع القواعد
        rules = re.findall(r'([^{}]+)\s*\{([^{}]*)\}', css_content, re.DOTALL)
        
        extracted_data = {
            'classes': set(),
            'ids': set(),
            'elements': set(),
            'pseudo_classes': set(),
            'complex_selectors': [],
            'media_queries': [],
            'keyframes': []
        }
        
        for selector_group, properties in rules:
            # تنظيف المحدد
            selector_group = selector_group.strip()
            
            # تقسيم المحددات المتعددة
            selectors = [s.strip() for s in selector_group.split(',')]
            
            for selector in selectors:
                if not selector:
                    continue
                    
                # حفظ الخصائص
                properties_dict = self.parse_properties(properties)
                
                # تحليل نوع المحدد
                self.analyze_selector(selector, properties_dict, extracted_data, source_file)
        
        return extracted_data
    
    def parse_properties(self, properties_str):
        """تحليل خصائص CSS"""
        properties = {}
        
        # تقسيم الخصائص
        prop_list = [p.strip() for p in properties_str.split(';') if p.strip()]
        
        for prop in prop_list:
            if ':' in prop:
                key, value = prop.split(':', 1)
                properties[key.strip()] = value.strip()
        
        return properties
    
    def analyze_selector(self, selector, properties, extracted_data, source_file):
        """تحليل المحدد وتصنيفه"""
        
        # إزالة المسافات الزائدة
        selector = re.sub(r'\s+', ' ', selector.strip())
        
        # فحص أنواع المحددات
        if selector.startswith('@media'):
            extracted_data['media_queries'].append({
                'selector': selector,
                'properties': properties,
                'source': source_file
            })
        elif selector.startswith('@keyframes'):
            extracted_data['keyframes'].append({
                'selector': selector,
                'properties': properties,
                'source': source_file
            })
        else:
            # استخراج الكلاسات من المحدد
            class_matches = re.findall(r'\.([a-zA-Z0-9_-]+)', selector)
            for class_name in class_matches:
                extracted_data['classes'].add(class_name)
            
            # استخراج المعرفات
            id_matches = re.findall(r'#([a-zA-Z0-9_-]+)', selector)
            for id_name in id_matches:
                extracted_data['ids'].add(id_name)
            
            # استخراج العناصر
            element_matches = re.findall(r'\b([a-z]+)\b(?!\s*[\.#\[])', selector)
            for element in element_matches:
                if element not in ['not', 'and', 'or']:  # تجنب الكلمات المحجوزة
                    extracted_data['elements'].add(element)
            
            # استخراج الفئات الزائفة
            pseudo_matches = re.findall(r':([a-zA-Z0-9_-]+)', selector)
            for pseudo in pseudo_matches:
                extracted_data['pseudo_classes'].add(pseudo)
            
            # حفظ المحدد المعقد
            if len(selector.split()) > 1 or any(char in selector for char in ['+', '>', '~', '[', ':']):
                extracted_data['complex_selectors'].append({
                    'selector': selector,
                    'properties': properties,
                    'source': source_file
                })
    
    def process_theme_folder(self, theme_path):
        """معالجة مجلد ثيم كامل"""
        theme_name = os.path.basename(theme_path)
        theme_data = {
            'name': theme_name,
            'files': {},
            'all_classes': set(),
            'all_ids': set(),
            'all_elements': set(),
            'statistics': {}
        }
        
        # البحث عن جميع ملفات CSS
        css_files = list(Path(theme_path).glob('*.css'))
        
        for css_file in css_files:
            print(f"📄 معالجة ملف: {css_file.name}")
            
            try:
                with open(css_file, 'r', encoding='utf-8') as f:
                    content = f.read()
            except UnicodeDecodeError:
                with open(css_file, 'r', encoding='latin1') as f:
                    content = f.read()
            
            # استخراج البيانات
            file_data = self.extract_css_selectors(content, css_file.name)
            theme_data['files'][css_file.name] = file_data
            
            # تجميع البيانات
            theme_data['all_classes'].update(file_data['classes'])
            theme_data['all_ids'].update(file_data['ids'])
            theme_data['all_elements'].update(file_data['elements'])
        
        # إحصائيات
        theme_data['statistics'] = {
            'total_classes': len(theme_data['all_classes']),
            'total_ids': len(theme_data['all_ids']),
            'total_elements': len(theme_data['all_elements']),
            'total_files': len(theme_data['files'])
        }
        
        return theme_data
    
    def generate_reset_css(self, theme_data, output_file):
        """إنشاء ملف CSS Reset للثيم"""
        
        css_content = f"""/* ===== CSS RESET FOR {theme_data['name'].upper()} THEME ===== */
/* تم إنشاؤه تلقائياً من استخراج الكلاسات */
/* تاريخ الإنشاء: {datetime.now().strftime('%Y-%m-%d %H:%M:%S')} */

/* =================
   GLOBAL RESET
   ================= */

/* إعادة تعيين عامة لجميع العناصر */
* {{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}}

/* =================
   EXTRACTED CLASSES RESET
   ================= */

"""
        
        # إضافة reset لجميع الكلاسات المستخرجة
        classes_list = sorted(theme_data['all_classes'])
        
        # تجميع الكلاسات في مجموعات
        class_groups = self.group_classes_by_prefix(classes_list)
        
        for group_name, classes in class_groups.items():
            css_content += f"\n/* {group_name} Classes Reset */\n"
            
            # إنشاء محدد جماعي للكلاسات
            selector = ',\n'.join(f'.{cls}' for cls in classes)
            
            css_content += f"""{selector} {{
    /* إعادة تعيين أساسية */
    display: initial;
    position: initial;
    width: auto;
    height: auto;
    margin: 0;
    padding: 0;
    border: none;
    background: none;
    color: inherit;
    font: inherit;
    text-decoration: none;
    outline: none;
    
    /* تحضير للتخصيص */
    transition: all 0.3s ease;
}}

"""
        
        # إضافة reset للعناصر
        css_content += f"""
/* =================
   ELEMENTS RESET
   ================= */

"""
        
        elements_list = sorted(theme_data['all_elements'])
        for element in elements_list:
            if element not in ['html', 'body']:  # تجنب العناصر الأساسية
                css_content += f"""{element} {{
    margin: 0;
    padding: 0;
    border: none;
    background: none;
    font: inherit;
}}

"""
        
        # إضافة reset للمعرفات
        css_content += f"""
/* =================
   IDS RESET
   ================= */

"""
        
        ids_list = sorted(theme_data['all_ids'])
        for id_name in ids_list[:20]:  # أول 20 معرف لتجنب الملف الكبير
            css_content += f"""#{id_name} {{
    position: relative;
    margin: 0;
    padding: 0;
}}

"""
        
        css_content += """
/* =================
   UTILITY CLASSES
   ================= */

.reset-all {
    all: unset !important;
}

.reset-display {
    display: block !important;
}

.reset-position {
    position: relative !important;
}

.reset-margin {
    margin: 0 !important;
}

.reset-padding {
    padding: 0 !important;
}

/* إنهاء الملف */
"""
        
        # كتابة الملف
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write(css_content)
        
        print(f"✅ تم إنشاء ملف Reset: {output_file}")
    
    def group_classes_by_prefix(self, classes_list):
        """تجميع الكلاسات حسب البادئة"""
        groups = defaultdict(list)
        
        for cls in classes_list:
            # محاولة تحديد البادئة
            if cls.startswith('Page'):
                groups['Page Components'].append(cls)
            elif cls.startswith('Menu'):
                groups['Menu System'].append(cls)
            elif cls.startswith('Form'):
                groups['Form Elements'].append(cls)
            elif cls.startswith('Button') or cls.startswith('btn'):
                groups['Buttons'].append(cls)
            elif cls.startswith('Data') or cls.startswith('Grid'):
                groups['Data Views'].append(cls)
            elif cls.startswith('Tab'):
                groups['Navigation'].append(cls)
            elif cls.startswith('Field') or cls.startswith('Input'):
                groups['Form Fields'].append(cls)
            elif cls.startswith('Header') or cls.startswith('Footer'):
                groups['Layout'].append(cls)
            else:
                groups['General'].append(cls)
        
        return dict(groups)
    
    def generate_json_report(self, theme_data, output_file):
        """إنشاء تقرير JSON مفصل"""
        
        # تحويل sets إلى lists للـ JSON
        json_data = {
            'theme_name': theme_data['name'],
            'extraction_date': datetime.now().isoformat(),
            'statistics': theme_data['statistics'],
            'all_classes': sorted(list(theme_data['all_classes'])),
            'all_ids': sorted(list(theme_data['all_ids'])),
            'all_elements': sorted(list(theme_data['all_elements'])),
            'files_analysis': {}
        }
        
        # تحليل كل ملف
        for filename, file_data in theme_data['files'].items():
            json_data['files_analysis'][filename] = {
                'classes': sorted(list(file_data['classes'])),
                'ids': sorted(list(file_data['ids'])),
                'elements': sorted(list(file_data['elements'])),
                'pseudo_classes': sorted(list(file_data['pseudo_classes'])),
                'complex_selectors': file_data['complex_selectors'][:10],  # أول 10 فقط
                'media_queries': file_data['media_queries'],
                'keyframes': file_data['keyframes']
            }
        
        # كتابة JSON
        with open(output_file, 'w', encoding='utf-8') as f:
            json.dump(json_data, f, ensure_ascii=False, indent=2)
        
        print(f"✅ تم إنشاء تقرير JSON: {output_file}")

# تشغيل النظام
if __name__ == "__main__":
    from datetime import datetime
    
    print("🎨 بدء استخراج الكلاسات من Citrus Theme...")
    
    # إنشاء المستخرج
    extractor = CSSClassExtractor()
    
    # معالجة مجلد Citrus
    citrus_path = "App_Themes/Citrus"
    
    if os.path.exists(citrus_path):
        theme_data = extractor.process_theme_folder(citrus_path)
        
        # إنشاء التقارير
        extractor.generate_json_report(theme_data, "citrus-classes-analysis.json")
        extractor.generate_reset_css(theme_data, "css/citrus-reset.css")
        
        print(f"""
🎉 تم إنجاز الاستخراج بنجاح!

📊 إحصائيات Citrus Theme:
- عدد الكلاسات: {theme_data['statistics']['total_classes']}
- عدد المعرفات: {theme_data['statistics']['total_ids']}
- عدد العناصر: {theme_data['statistics']['total_elements']}
- عدد الملفات: {theme_data['statistics']['total_files']}

📁 الملفات المُنشأة:
- citrus-classes-analysis.json (تقرير مفصل)
- css/citrus-reset.css (ملف إعادة التعيين)
        """)
        
    else:
        print(f"❌ لم يتم العثور على مجلد: {citrus_path}")
