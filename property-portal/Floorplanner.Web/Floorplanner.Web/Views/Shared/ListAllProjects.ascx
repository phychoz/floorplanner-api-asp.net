<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<ProjectCollection>" %>
<%@ Import Namespace="Floorplanner.Web.Models.Entity" %>
<div id="allProjcts">
    <h1>Projects</h1>
    
    <table>
        <tr>
            <th>
                Name
            </th>
            <th>
                ID
            </th>
            <th>
                Modify
            </th>
            <th>
                Delete
            </th>
            <th>
                Export
            </th>
        </tr>
        <% foreach (var item in ((ProjectCollection)ViewData["Projects"]).Projects)
       {%>
        <tr>
            <td>
                <%= Html.ActionLink(item.Name, "Details", "Project", new {id = item.Id, userId = item.UserId}, null) %>
            </td>
            <td>
                <%= item.Id %>
            </td>
            <td>
                <%= Html.ActionLink("Modify", "Edit", "Project", new {id=item.Id, userId = item.UserId}, null) %>
            </td>
            <td>
                <%= Ajax.ActionLink("Delete", "Delete", "Project", new { id = item.Id, userId = item.UserId }, new AjaxOptions { UpdateTargetId = "message"}, new {onClick = "return confirm('Are you sure you wanna delete this user?')" }) %>
            </td>
            <td>
                <a href="http://floorplanner.com/projects/<%= item.Id %>/export.fml">Export it!</a>
            </td>
        </tr>
        <%}%>
    </table>
    <div class="clear"></div>
</div>
