<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Floorplanner.Web.Models.Entity.Project>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Projects
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        List of all projects created by uid:<%= ViewData["UserId"] %> [<%= Html.ActionLink("+ add project", "Add", "Project", new {userId = Convert.ToInt32(ViewData["UserId"])}, null) %>]
    </h1>
    <% Html.RenderPartial("ListAllProjects"); %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsContentPlaceHolder" runat="server">
</asp:Content>
