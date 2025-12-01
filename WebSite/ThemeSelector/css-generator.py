#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
🎨 مولد ملفات CSS الفيزيائية للثيمات
Physical CSS Files Generator from JSON
Created: 2025-08-07
"""

import os
import json
from datetime import datetime

def load_themes_config():
    """تحميل إعدادات الثيمات من JSON"""
    config_path = r"E:\2021-06-HP-D-drive\2021_07_CodeOnTime\105ClassicVBREPOS\105-1001SASERP811V37\WebSite\ThemeSelector\data\themes-config.json"
    
    try:
        with open(config_path, 'r', encoding='utf-8') as file:
            return json.load(file)
    except Exception as e:
        print(f"❌ خطأ في تحميل إعدادات الثيمات: {e}")
        return None

def generate_css_variables(variables):
    """تحويل متغيرات الثيم إلى CSS Variables"""
    css_vars = ":root {\n"
    for var_name, var_value in variables.items():
        css_vars += f"    {var_name}: {var_value};\n"
    css_vars += "}\n\n"
    return css_vars

def generate_css_classes(classes):
    """تحويل كلاسات الثيم إلى CSS"""
    css_classes = ""
    for class_name, class_props in classes.items():
        css_classes += f"{class_name} {{\n"
        for prop_name, prop_value in class_props.items():
            css_classes += f"    {prop_name}: {prop_value};\n"
        css_classes += "}\n\n"
    return css_classes

def generate_theme_css(theme_id, theme_data):
    """إنشاء ملف CSS كامل لثيم معين"""
    
    header = f"""/*
 * 🎨 {theme_data['name']} Theme - {theme_data['nameEn']}
 * {theme_data['description']}
 * Generated: {datetime.now().strftime('%Y-%m-%d %H:%M:%S')}
 * Category: {theme_data['category']}
 * Premium: {'Yes' if theme_data['isPremium'] else 'No'}
 */

"""
    
    # CSS Variables
    variables_css = generate_css_variables(theme_data['variables'])
    
    # CSS Classes
    classes_css = generate_css_classes(theme_data['cssClasses'])
    
    # Base theme styles
    base_styles = f"""/* Base Theme Styles */
body {{
    background-color: {theme_data['colors']['background']};
    color: {theme_data['colors']['text']};
    font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}}

/* Common Elements */
.container {{
    background-color: {theme_data['colors']['surface']};
}}

/* Links */
a {{
    color: {theme_data['colors']['primary']};
}}

a:hover {{
    color: {theme_data['colors']['secondary']};
}}

/* Tables */
.table {{
    background-color: {theme_data['colors']['surface']};
    color: {theme_data['colors']['text']};
}}

.table th {{
    background-color: {theme_data['colors']['primary']};
    color: #ffffff;
    border-color: {theme_data['colors']['primary']};
}}

.table td {{
    border-color: {theme_data['colors']['text']};
}}

/* Forms */
.form-control {{
    background-color: {theme_data['colors']['surface']};
    color: {theme_data['colors']['text']};
    border-color: {theme_data['colors']['text']};
}}

.form-control:focus {{
    border-color: {theme_data['colors']['primary']};
    box-shadow: 0 0 0 0.2rem {theme_data['colors']['primary']}40;
}}

/* Buttons */
.btn-secondary {{
    background-color: {theme_data['colors']['secondary']};
    border-color: {theme_data['colors']['secondary']};
}}

.btn-secondary:hover {{
    background-color: {theme_data['colors']['primary']};
    border-color: {theme_data['colors']['primary']};
}}

/* Navigation */
.navbar {{
    background-color: {theme_data['colors']['primary']} !important;
}}

.navbar-brand, .navbar-nav .nav-link {{
    color: #ffffff !important;
}}

/* Sidebar */
.sidebar {{
    background-color: {theme_data['colors']['surface']};
    border-color: {theme_data['colors']['text']};
}}

/* Footer */
.footer {{
    background-color: {theme_data['colors']['primary']};
    color: #ffffff;
}}

"""
    
    return header + variables_css + classes_css + base_styles

def generate_all_themes():
    """إنشاء جميع ملفات CSS للثيمات"""
    config = load_themes_config()
    if not config:
        return
    
    output_dir = r"E:\2021-06-HP-D-drive\2021_07_CodeOnTime\105ClassicVBREPOS\105-1001SASERP811V37\WebSite\css\themes-physical"
    
    print("🎨 بدء إنشاء ملفات CSS الفيزيائية...")
    
    for theme_id, theme_data in config['themes'].items():
        print(f"📝 إنشاء: {theme_data['name']} ({theme_id})")
        
        # إنشاء محتوى CSS
        css_content = generate_theme_css(theme_id, theme_data)
        
        # حفظ الملف
        output_file = os.path.join(output_dir, theme_data['cssFile'])
        
        try:
            with open(output_file, 'w', encoding='utf-8') as file:
                file.write(css_content)
            print(f"✅ تم حفظ: {output_file}")
        except Exception as e:
            print(f"❌ خطأ في حفظ {theme_id}: {e}")
    
    print(f"\n🎯 تم إنشاء {len(config['themes'])} ملف CSS بنجاح!")

def generate_index_css():
    """إنشاء ملف index يحتوي على جميع الثيمات"""
    config = load_themes_config()
    if not config:
        return
    
    index_content = f"""/*
 * 🎨 SASERP Themes Index
 * All available themes for the system
 * Generated: {datetime.now().strftime('%Y-%m-%d %H:%M:%S')}
 */

/* Available Themes:
"""
    
    for theme_id, theme_data in config['themes'].items():
        index_content += f" * - {theme_data['name']} ({theme_id}): {theme_data['description']}\n"
    
    index_content += """ */

/* To apply a theme, copy the content from the respective theme file to stylesheet.css */

/* Default Theme: Citrus */
@import url('citrus-theme.css');
"""
    
    output_file = r"E:\2021-06-HP-D-drive\2021_07_CodeOnTime\105ClassicVBREPOS\105-1001SASERP811V37\WebSite\css\themes-physical\themes-index.css"
    
    try:
        with open(output_file, 'w', encoding='utf-8') as file:
            file.write(index_content)
        print(f"📋 تم إنشاء فهرس الثيمات: {output_file}")
    except Exception as e:
        print(f"❌ خطأ في إنشاء الفهرس: {e}")

def main():
    print("🚀 مولد ملفات CSS الفيزيائية للثيمات")
    print("=" * 50)
    
    # إنشاء جميع ملفات الثيمات
    generate_all_themes()
    
    # إنشاء فهرس الثيمات
    generate_index_css()
    
    print("\n✨ اكتمل إنشاء نظام الثيمات الفيزيائي!")

if __name__ == "__main__":
    main()
