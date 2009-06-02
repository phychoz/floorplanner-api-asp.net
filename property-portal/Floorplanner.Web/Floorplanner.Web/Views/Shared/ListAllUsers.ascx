<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UserCollection>" %>
<%@ Import Namespace="Floorplanner.Web.Models.Entity" %>
<div id="allUsers">
    <h1>
        Users [<%= Html.ActionLink("+ add user", "Add", "User") %>]
    </h1>
    <div id="message">
    </div>
    <table>
        <tr>
            <th>
                EID
            </th>
            <th>
                Email
            </th>
            <th>
                Modify
            </th>
            <th>
                Delete
            </th>
        </tr>
        <% foreach (var item in ((UserCollection)ViewData["Users"]).Users)
           {%>
        <tr>
            <td>
                <%= item.ExternalIdentifier %>
            </td>
            <td>
                <%= item.Email %>
            </td>
            <td>
                <%= Html.ActionLink("Modify", "Edit", "User", new {id=item.Id}, null) %>
            </td>
            <td>
                <%= Ajax.ActionLink("Delete", "Delete", "User", new { id = item.Id }, new AjaxOptions { UpdateTargetId = "message"}, new {onClick = "return confirm('Are you sure you wanna delete this user?')" }) %>
            </td>
        </tr>
        <%}%>
    </table>
    <div class="clear">
    </div>
</div>
