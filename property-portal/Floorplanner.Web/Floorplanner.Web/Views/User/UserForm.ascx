<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Floorplanner.Web.Models.Entity.User>" %>
<%= Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.") %>
<% using (Html.BeginForm())
   {%>
<fieldset>
    <p>
        <label for="Company">
            Company:</label>
        <%= Html.TextBox("Company") %>
        <%= Html.ValidationMessage("Company", "*") %>
    </p>
    <p>
        <label for="Email">
            Email:</label>
        <%= Html.TextBox("Email") %>
        <%= Html.ValidationMessage("Email", "*") %>
    </p>
    <p>
        <label for="ExternalIdentifier">
            External Identifier (EID):</label>
        <%= Html.TextBox("ExternalIdentifier") %>
        <%= Html.ValidationMessage("ExternalIdentifier", "*") %>
    </p>
    <p>
        <input type="submit" value="save" />
    </p>
</fieldset>
<% } %>
<div>
    <%=Html.ActionLink("Back to List", "LoggedInAsAdministrator", "Home") %>
</div>
