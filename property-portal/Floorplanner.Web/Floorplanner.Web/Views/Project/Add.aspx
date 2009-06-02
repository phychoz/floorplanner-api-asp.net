<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Floorplanner.Web.Models.Entity.Project>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Add New Project
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% Html.RenderPartial("ProjectForm"); %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsContentPlaceHolder" runat="server">

    <script type="text/javascript" src="/Scripts/jquery-1.3.2.js"></script>

</asp:Content>
