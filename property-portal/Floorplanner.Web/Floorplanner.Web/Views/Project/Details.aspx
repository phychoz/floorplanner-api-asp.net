<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" %>

<%@ Import Namespace="Floorplanner.Web.Models.Entity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Project 2D Model
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src="/Scripts/jquery-1.3.2-vsdoc.js"></script>

    <h1>
        This is a 2D model of "<%= ((Project)(ViewData["Project"])).Name %>" project.
    </h1>
    <input type="hidden" id="ProjectId" value="<%= ((Project)(ViewData["Project"])).Id %>" />
    <input type="hidden" id="Token" value="<%= ViewData["Token"].ToString() %>" />
    <h2>
        <% foreach (var floor in ((Project)(ViewData["Project"])).Floors.Floors)
           {%>
        <a href="#" onmouseover="fp.showForm('SELECT_DESIGN', {floorId:<%= floor.Id %>, xPos:100});">
            <%= floor.Name %></a> |
        <%
            }%>
    </h2>
    <h2 style="float: right;">
        <a href="#" onclick="fp.resetDesign(); return false;">New</a> | 
        <a href="#" onclick="fp.showForm('SAVE'); return false;">Save</a> | 
        <a href="#" onclick="fp.showForm('PROJECT_SETTINGS'); return false;">Settings</a> | 
        <a href="#" onclick="fp.showForm('PRINT'); return false;">Print</a> | 
        <a href="#" onclick="fp.showForm('EXPORT_IMAGE'); return false;">Export image</a> | 
        <a href="#" onclick="fp.showForm('SEND_A_FRIEND'); return false;">Save and email</a> | 
        <a href="#" onclick="fp.showForm('ADD_FLOOR'); return false;">Add Floor</a> | 
    </h2>
    <div id="flashObjectDiv" style="width: 800px;">
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsContentPlaceHolder" runat="server">

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/swfobject/2.1/swfobject.js"></script>

    <script type="text/javascript" src="http://floorplanner.com/javascripts/floorplanner/floorplanner.js"></script>

    <script type="text/javascript" src="/Scripts/jquery-1.3.2.js"></script>

    <script type="text/javascript">
    <!--
        var projectId = $("#ProjectId").val();
        var token = $("#Token").val();
        var fp = new Floorplanner({ project_id: projectId, token: token, state: Floorplanner.STATE_EDIT }); // Create the Floorplanner object
        window.onload = function() { fp.embed("flashObjectDiv") };
    -->
    </script>

</asp:Content>
