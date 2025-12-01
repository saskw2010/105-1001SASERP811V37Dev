#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
🎨 Advanced CSS Classes Extractor & Analyzer
استخراج وتحليل جميع الكلاسات من ملفات CSS مع معالجة التكرار والتراكب
"""

import re
import json
import os
from collections import defaultdict, OrderedDict
from pathlib import Path
from datetime import datetime

class AdvancedCSSExtractor:
    def __init__(self):
        self.global_classes = {}  # جميع الكلاسات مع تعريفاتها
        self.duplicate_classes = defaultdict(list)  # الكلاسات المكررة
        self.file_hierarchy = {}  # هيكل الملفات
        self.class_sources = defaultdict(set)  # مصادر كل كلاس
        self.merged_definitions = {}  # التعريفات المدمجة
        
    def extract_css_with_definitions(self, css_content, source_file=""):
        """استخراج CSS مع الاحتفاظ بالتعريفات الكاملة"""
        
        # إزالة التعليقات مع الاحتفاظ بالبنية
        css_content = re.sub(r'/\*.*?\*/', '', css_content, flags=re.DOTALL)
        
        # استخراج @import statements
        imports = re.findall(r'@import\s+(?:url\()?["\']?([^"\';\)]+)["\']?\)?[^;]*;', css_content)
        
        # استخراج @media queries
        media_queries = re.findall(r'(@media[^{]+\{[^{}]*(?:\{[^{}]*\}[^{}]*)*\})', css_content, re.DOTALL)
        
        # استخراج القواعد العادية
        # نمط أكثر دقة للقواعد
        rules_pattern = r'([^{}@]+)\s*\{([^{}]*(?:\{[^{}]*\}[^{}]*)*)\}'
        rules = re.findall(rules_pattern, css_content, re.DOTALL)
        
        extracted_data = {
            'source_file': source_file,
            'imports': imports,
            'media_queries': media_queries,
            'classes': {},
            'ids': {},
            'elements': {},
            'complex_selectors': {},
            'statistics': {
                'total_selectors': 0,
                'classes_count': 0,
                'ids_count': 0,
                'elements_count': 0
            }
        }
        
        for selector_group, properties in rules:
            selector_group = selector_group.strip()
            properties = properties.strip()
            
            if not selector_group or not properties:
                continue
            
            # تقسيم المحددات المتعددة
            selectors = [s.strip() for s in selector_group.split(',') if s.strip()]
            
            for selector in selectors:
                extracted_data['statistics']['total_selectors'] += 1
                
                # تحليل المحدد
                self.analyze_selector_advanced(selector, properties, extracted_data, source_file)
        
        return extracted_data
    
    def analyze_selector_advanced(self, selector, properties, extracted_data, source_file):
        """تحليل متقدم للمحددات مع معالجة التداخل"""
        
        # تنظيف المحدد
        clean_selector = re.sub(r'\s+', ' ', selector.strip())
        
        # معلومات المحدد
        selector_info = {
            'selector': clean_selector,
            'properties': self.parse_properties_advanced(properties),
            'source': source_file,
            'specificity': self.calculate_specificity(clean_selector),
            'type': self.determine_selector_type(clean_selector)
        }
        
        # استخراج الكلاسات
        class_matches = re.findall(r'\.([a-zA-Z0-9_-]+)', clean_selector)
        for class_name in class_matches:
            if class_name not in extracted_data['classes']:
                extracted_data['classes'][class_name] = []
            extracted_data['classes'][class_name].append(selector_info)
            extracted_data['statistics']['classes_count'] += 1
            
            # تسجيل الكلاس في النظام العام
            self.register_class_globally(class_name, selector_info)
        
        # استخراج المعرفات
        id_matches = re.findall(r'#([a-zA-Z0-9_-]+)', clean_selector)
        for id_name in id_matches:
            if id_name not in extracted_data['ids']:
                extracted_data['ids'][id_name] = []
            extracted_data['ids'][id_name].append(selector_info)
            extracted_data['statistics']['ids_count'] += 1
        
        # استخراج العناصر
        element_matches = re.findall(r'\b(a|div|span|table|tr|td|th|img|input|button|form|body|html|h[1-6]|p|ul|li|ol|iframe|select|textarea)\b', clean_selector)
        for element in element_matches:
            if element not in extracted_data['elements']:
                extracted_data['elements'][element] = []
            extracted_data['elements'][element].append(selector_info)
            extracted_data['statistics']['elements_count'] += 1
        
        # حفظ المحددات المعقدة
        if self.is_complex_selector(clean_selector):
            if clean_selector not in extracted_data['complex_selectors']:
                extracted_data['complex_selectors'][clean_selector] = []
            extracted_data['complex_selectors'][clean_selector].append(selector_info)
    
    def register_class_globally(self, class_name, selector_info):
        """تسجيل الكلاس في النظام العام مع معالجة التكرار"""
        
        if class_name not in self.global_classes:
            self.global_classes[class_name] = []
        
        self.global_classes[class_name].append(selector_info)
        self.class_sources[class_name].add(selector_info['source'])
        
        # فحص التكرار
        if len(self.global_classes[class_name]) > 1:
            self.duplicate_classes[class_name] = self.global_classes[class_name]
    
    def parse_properties_advanced(self, properties_str):
        """تحليل متقدم لخصائص CSS"""
        properties = OrderedDict()
        
        # تقسيم الخصائص مع معالجة القيم المعقدة
        prop_pattern = r'([^:;]+):\s*([^;]+(?:;[^:;]*)*)'
        matches = re.findall(prop_pattern, properties_str)
        
        for prop, value in matches:
            prop = prop.strip()
            value = value.strip().rstrip(';')
            
            if prop and value:
                properties[prop] = {
                    'value': value,
                    'important': '!important' in value,
                    'variables': re.findall(r'var\([^)]+\)', value),
                    'functions': re.findall(r'(\w+)\([^)]*\)', value)
                }
        
        return properties
    
    def calculate_specificity(self, selector):
        """حساب specificity للمحدد"""
        # عدد المعرفات
        ids = len(re.findall(r'#[a-zA-Z0-9_-]+', selector))
        
        # عدد الكلاسات والخصائص والفئات الزائفة
        classes = len(re.findall(r'\.[a-zA-Z0-9_-]+', selector))
        attributes = len(re.findall(r'\[[^\]]+\]', selector))
        pseudo_classes = len(re.findall(r':[a-zA-Z0-9_-]+(?!\:)', selector))
        
        # عدد العناصر والفئات الزائفة للعناصر
        elements = len(re.findall(r'\b(a|div|span|table|tr|td|th|img|input|button|form|body|html|h[1-6]|p|ul|li|ol|iframe|select|textarea)\b', selector))
        pseudo_elements = len(re.findall(r'::[a-zA-Z0-9_-]+', selector))
        
        return {
            'ids': ids,
            'classes': classes + attributes + pseudo_classes,
            'elements': elements + pseudo_elements,
            'score': ids * 100 + (classes + attributes + pseudo_classes) * 10 + (elements + pseudo_elements)
        }
    
    def determine_selector_type(self, selector):
        """تحديد نوع المحدد"""
        if '@' in selector:
            return 'at-rule'
        elif '::' in selector:
            return 'pseudo-element'
        elif ':' in selector:
            return 'pseudo-class'
        elif '[' in selector and ']' in selector:
            return 'attribute'
        elif '#' in selector:
            return 'id'
        elif '.' in selector:
            return 'class'
        elif any(op in selector for op in ['+', '>', '~']):
            return 'combinator'
        else:
            return 'element'
    
    def is_complex_selector(self, selector):
        """فحص ما إذا كان المحدد معقد"""
        complexity_indicators = [
            len(selector.split()) > 2,  # أكثر من عنصرين
            any(op in selector for op in ['+', '>', '~']),  # combinators
            '[' in selector and ']' in selector,  # attribute selectors
            ':' in selector,  # pseudo selectors
            selector.count('.') > 2,  # أكثر من كلاسين
            selector.count('#') > 1   # أكثر من معرف
        ]
        
        return any(complexity_indicators)
    
    def process_multiple_files(self, file_paths):
        """معالجة ملفات متعددة"""
        results = {}
        
        for file_path in file_paths:
            print(f"📄 معالجة: {file_path}")
            
            if not os.path.exists(file_path):
                print(f"❌ الملف غير موجود: {file_path}")
                continue
            
            try:
                with open(file_path, 'r', encoding='utf-8') as f:
                    content = f.read()
            except UnicodeDecodeError:
                try:
                    with open(file_path, 'r', encoding='latin1') as f:
                        content = f.read()
                except Exception as e:
                    print(f"❌ خطأ في قراءة {file_path}: {e}")
                    continue
            
            # استخراج البيانات
            file_data = self.extract_css_with_definitions(content, os.path.basename(file_path))
            results[file_path] = file_data
        
        return results
    
    def merge_duplicate_classes(self):
        """دمج الكلاسات المكررة بذكاء"""
        
        for class_name, definitions in self.duplicate_classes.items():
            merged_properties = OrderedDict()
            sources = []
            
            # ترتيب التعريفات حسب الـ specificity
            sorted_definitions = sorted(definitions, key=lambda x: x['specificity']['score'])
            
            for definition in sorted_definitions:
                sources.append(f"{definition['source']}:{definition['selector']}")
                
                # دمج الخصائص (الأخير يغلب)
                for prop, prop_data in definition['properties'].items():
                    merged_properties[prop] = prop_data
            
            self.merged_definitions[class_name] = {
                'merged_properties': merged_properties,
                'sources': sources,
                'total_definitions': len(definitions),
                'final_specificity': sorted_definitions[-1]['specificity']
            }
    
    def generate_comprehensive_report(self, results, output_file):
        """إنشاء تقرير شامل"""
        
        # دمج الكلاسات المكررة
        self.merge_duplicate_classes()
        
        # إحصائيات عامة
        all_classes = set()
        all_ids = set()
        all_elements = set()
        
        for file_data in results.values():
            all_classes.update(file_data['classes'].keys())
            all_ids.update(file_data['ids'].keys())
            all_elements.update(file_data['elements'].keys())
        
        report = {
            'extraction_info': {
                'date': datetime.now().isoformat(),
                'total_files': len(results),
                'extractor_version': '2.0.0'
            },
            'global_statistics': {
                'unique_classes': len(all_classes),
                'unique_ids': len(all_ids),
                'unique_elements': len(all_elements),
                'duplicate_classes': len(self.duplicate_classes),
                'total_class_definitions': sum(len(defs) for defs in self.global_classes.values())
            },
            'files_analysis': {},
            'duplicate_classes_analysis': {},
            'merged_definitions': {},
            'class_hierarchy': self.build_class_hierarchy(all_classes),
            'recommendations': self.generate_recommendations()
        }
        
        # تحليل الملفات
        for file_path, file_data in results.items():
            report['files_analysis'][os.path.basename(file_path)] = {
                'statistics': file_data['statistics'],
                'imports': file_data['imports'],
                'classes': list(file_data['classes'].keys()),
                'ids': list(file_data['ids'].keys()),
                'elements': list(file_data['elements'].keys()),
                'has_media_queries': len(file_data['media_queries']) > 0,
                'complex_selectors_count': len(file_data['complex_selectors'])
            }
        
        # تحليل الكلاسات المكررة
        for class_name, definitions in self.duplicate_classes.items():
            report['duplicate_classes_analysis'][class_name] = {
                'occurrences': len(definitions),
                'sources': list(self.class_sources[class_name]),
                'different_properties': len(set(
                    str(sorted(d['properties'].keys())) for d in definitions
                )) > 1,
                'max_specificity': max(d['specificity']['score'] for d in definitions)
            }
        
        # التعريفات المدمجة
        for class_name, merged_data in self.merged_definitions.items():
            report['merged_definitions'][class_name] = {
                'sources': merged_data['sources'],
                'total_definitions': merged_data['total_definitions'],
                'properties_count': len(merged_data['merged_properties']),
                'final_specificity': merged_data['final_specificity']['score']
            }
        
        # كتابة التقرير
        with open(output_file, 'w', encoding='utf-8') as f:
            json.dump(report, f, ensure_ascii=False, indent=2)
        
        print(f"✅ تم إنشاء التقرير الشامل: {output_file}")
        return report
    
    def build_class_hierarchy(self, classes):
        """بناء هيكل هرمي للكلاسات"""
        hierarchy = defaultdict(list)
        
        for class_name in sorted(classes):
            # تصنيف حسب البادئة
            if class_name.startswith('Page'):
                hierarchy['Page System'].append(class_name)
            elif class_name.startswith('Menu') or class_name.startswith('Navigation'):
                hierarchy['Menu & Navigation'].append(class_name)
            elif class_name.startswith('Data') or class_name.startswith('Grid') or class_name.startswith('Table'):
                hierarchy['Data Display'].append(class_name)
            elif class_name.startswith('Form') or class_name.startswith('Input') or class_name.startswith('Field'):
                hierarchy['Forms & Inputs'].append(class_name)
            elif class_name.startswith('Button') or class_name.startswith('btn'):
                hierarchy['Buttons & Actions'].append(class_name)
            elif class_name.startswith('Header') or class_name.startswith('Footer') or class_name.startswith('Layout'):
                hierarchy['Layout & Structure'].append(class_name)
            elif class_name.startswith('Modal') or class_name.startswith('Dialog') or class_name.startswith('Popup'):
                hierarchy['Modals & Dialogs'].append(class_name)
            elif class_name.startswith('Tab') or class_name.startswith('Accordion'):
                hierarchy['UI Components'].append(class_name)
            elif class_name.startswith('Login') or class_name.startswith('Member') or class_name.startswith('User'):
                hierarchy['Authentication'].append(class_name)
            else:
                hierarchy['General & Utilities'].append(class_name)
        
        return dict(hierarchy)
    
    def generate_recommendations(self):
        """إنشاء توصيات للتحسين"""
        recommendations = []
        
        # توصيات للكلاسات المكررة
        if self.duplicate_classes:
            recommendations.append({
                'type': 'duplicates',
                'priority': 'high',
                'message': f'يوجد {len(self.duplicate_classes)} كلاس مكرر يحتاج مراجعة ودمج',
                'action': 'قم بمراجعة الكلاسات المكررة ودمجها في ملف CSS موحد'
            })
        
        # توصيات للتنظيم
        if len(self.global_classes) > 100:
            recommendations.append({
                'type': 'organization',
                'priority': 'medium',
                'message': 'عدد كبير من الكلاسات يحتاج تنظيم أفضل',
                'action': 'قسم الكلاسات إلى ملفات منفصلة حسب الوظيفة'
            })
        
        # توصيات للأداء
        complex_selectors = sum(
            len(data.get('complex_selectors', {})) 
            for data in [getattr(self, 'current_file_data', {})]
        )
        
        if complex_selectors > 20:
            recommendations.append({
                'type': 'performance',
                'priority': 'medium',
                'message': 'عدد كبير من المحددات المعقدة قد يؤثر على الأداء',
                'action': 'بسط المحددات المعقدة واستخدم كلاسات مباشرة'
            })
        
        return recommendations

# تشغيل النظام المتقدم
if __name__ == "__main__":
    print("🚀 بدء النظام المتقدم لاستخراج وتحليل CSS...")
    
    # إنشاء المستخرج المتقدم
    extractor = AdvancedCSSExtractor()
    
    # قائمة الملفات للمعالجة
    css_files = [
        "App_Themes/Citrus/Citrus.css",
        "App_Themes/_Shared/_Layout.css",
        "App_Themes/_Shared/Core.css",
        "App_Themes/_Shared/Membership.css",
        "App_Themes/eZee/StyleSheet.css"
    ]
    
    # البحث عن ملفات إضافية
    additional_css = []
    for pattern in ["css/*.css", "App_Themes/*/*.css"]:
        for path in Path(".").glob(pattern):
            if str(path) not in css_files:
                additional_css.append(str(path))
    
    all_files = css_files + additional_css
    
    print(f"📁 سيتم معالجة {len(all_files)} ملف CSS")
    
    # معالجة جميع الملفات
    results = extractor.process_multiple_files(all_files)
    
    # إنشاء التقرير الشامل
    report = extractor.generate_comprehensive_report(results, "comprehensive-css-analysis.json")
    
    print(f"""
🎉 تم إنجاز التحليل الشامل!

📊 الإحصائيات النهائية:
- إجمالي الكلاسات الفريدة: {report['global_statistics']['unique_classes']}
- إجمالي المعرفات: {report['global_statistics']['unique_ids']}
- إجمالي العناصر: {report['global_statistics']['unique_elements']}
- الكلاسات المكررة: {report['global_statistics']['duplicate_classes']}
- الملفات المعالجة: {report['global_statistics']['total_files']}

📁 الملفات المُنشأة:
- comprehensive-css-analysis.json (تقرير شامل مع معالجة التكرار)

💡 التوصيات: {len(report['recommendations'])} توصية للتحسين
    """)
    
    # طباعة الكلاسات المكررة إذا وجدت
    if report['global_statistics']['duplicate_classes'] > 0:
        print("\n⚠️  الكلاسات المكررة الأكثر أهمية:")
        for class_name, analysis in list(report['duplicate_classes_analysis'].items())[:5]:
            print(f"  • {class_name}: {analysis['occurrences']} تعريف في {len(analysis['sources'])} ملف")
