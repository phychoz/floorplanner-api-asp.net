<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="Floorplanner.Web.Models.Entity" %>
<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Floorplanner API Sample
</asp:Content>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <% using (Html.BeginForm())
       {%>
    <input type="submit" value="log in as administrator" />
    <%}%>
    <hr />
    <div>
        <% using (Html.BeginForm("LoginAsPro", "Home", FormMethod.Post, new {id = "ProLoginForm"}))
           {%>
        <select id="ProUserId" name="ProUserId">
            <% foreach (var user in ((UserCollection)(Model)).Users)
               {%>
               <option value="<%= user.Id %>"><%= user.Email %></option>
            <%} %>
        </select>
        <input type="submit" value="log in as a Pro user" />
        <%
            }%>
    </div>
</asp:Content>
