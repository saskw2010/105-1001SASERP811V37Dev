<%@ Control Language="VB" AutoEventWireup="false" CodeFile="eZeeErpModulesschool.ascx.vb" Inherits="Controls_eZeeErpModulesschool"  %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
 
    <link href="stylesheets/_layouts/dashboard.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/_styles/ui.all.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/modalbox.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/autosuggest-menu.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/user/dashboard.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/plugin_css/fedena_blog.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/plugin_css/fedena_custom_report.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/plugin_css/fedena_hostel.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/plugin_css/fedena_library.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/plugin_css/fedena_transport.css" media="screen" rel="stylesheet" type="text/css" />
<link href="stylesheets/calendar.css" media="screen" rel="stylesheet" type="text/css" />

    <script src="javascripts/cache/javascripts/all.js" type="text/javascript"></script>

    <script src="javascripts/scripts/nicetitle.js" type="text/javascript"></script>
<script src="javascripts/droplicious.js" type="text/javascript"></script>

    <script src="javascripts/fckeditor/fckeditor.js" type="text/javascript"></script>

    <script src="javascripts/builder.js" type="text/javascript"></script>

    <script src="javascripts/modalbox.js" type="text/javascript"></script>

    <script src="javascripts/jquery/jquery.min.js" type="text/javascript"></script>

    <script src="javascripts/jquery/jquery-ui.min.js" type="text/javascript"></script>

    <script src="javascripts/jquery/jquery.hotkeys.js" type="text/javascript"></script>
<p class="flash-msg"> Welcome, eZeeErp ! </p> 

<div id="user_options">

  
    <div class="button-box">
      <a href="/student/admission1" class="option_buttons" id="admission_button" title="Enter students admission details into the school records."><div class ='button-label'><p>Admission</p></div></a>
    </div>
    <div class="button-box">
      <a href="/student" class="option_buttons" id="student_details_button" title="Search for existing and former students."><div class ='button-label'><p>Student Details</p></div></a>
    </div>
    <div class="button-box">
      <a href="/user" class="option_buttons" id="manage_users_button" title="         Manage Users         "><div class ='button-label'><p> Manage Users </p></div></a>
    </div>
    <div class="button-box">
      <a href="/news" class="option_buttons" id="manage_news_button" title="View or publish latest school news and announcements"><div class ='button-label'><p>Manage News</p></div></a>

    </div>
    <div class="button-box">
      <a href="/exam" class="option_buttons" id="examinations_button" title="          Manage Examinations"><div class ='button-label'><p>Examinations</p></div></a>
    </div>
    <div class="button-box">
      <a href="/timetable" class="option_buttons" id="timetable_button" title="  Timetable management module  "><div class ='button-label'><p>Timetable</p></div></a>
    </div>
    <div class="button-box">
      <a href="/student_attendance" class="option_buttons" id="student_attendance_button" title="Manage the attendance for the students"><div class ='button-label'><p>Attendance</p></div></a>
    </div>
    <div class="button-box">
      <a href="/configuration" class="option_buttons" id="settings_button" title="Configure the basic school settings"><div class ='button-label'><p>Settings</p></div></a>
    </div>

    
      <div class="button-box">
        <a href="/employee/hr" class="option_buttons" id="hr_button" title="        Human Resource Department"><div class ='button-label'><p>Human Resources</p></div></a>
      </div>

    

    
      <div class="button-box">
        <a href="/finance" class="option_buttons" id="finance_button" title="        Manages Finance module    "><div class ='button-label'><p> Finance</p></div></a>
      </div>
    

  

  
    
  
    
  
    
  
    
      
        <div class="button-box">
          <a href="/blog_posts" class="option_buttons" id="blog_button" title="Post blog and view blogs by other users"><div class ="button-label"><p>Blog</p></div></a>
        </div>
      
    
  
    
  
    
  
    
  
    
  
    
  
    
  
    
  
    
  
    
      
        <div class="button-box">
          <a href="/hostels/hostel_dashboard" class="option_buttons" id="hostel_button" title="Manage Hostel"><div class ="button-label"><p>Hostel</p></div></a>
        </div>
      
    
  
    
  
    
  
    
  
    
      
        <div class="button-box">
          <a href="/library" class="option_buttons" id="library_button" title="Manage Library"><div class ="button-label"><p>Library</p></div></a>
        </div>
      
    
  
    
  
    
  
    
  
    
  
    
  
    
  
    
  
    
  
    
      
        <div class="button-box">
          <a href="/transport/dash_board" class="option_buttons" id="transport_button" title="Manage Transport"><div class ="button-label"><p>Transport</p></div></a>
        </div>
      
    
  

</div>

<div id="option_description"> </div>

<script type="text/javascript">
    $$('#user_options .button-box').each(function (ele, index) {
        if (index % 5 == 0) {
            ele.addClassName("left-button");
        }
    });
</script> 

      <div class="extender"></div>
    

