<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Logged in as an administrator
</asp:Content>
<asp:Content ID="Scripts" ContentPlaceHolderID="ScriptsContentPlaceHolder" runat="server">

    <script src="~/Scripts/MicrosoftAjax.js" type="text/javascript"></script>

    <script src="~/Scripts/MicrosoftMvcAjax.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% Html.RenderPartial("ListAllUsers"); %>
    <% Html.RenderPartial("ListAllProjects"); %>
</asp:Content>
