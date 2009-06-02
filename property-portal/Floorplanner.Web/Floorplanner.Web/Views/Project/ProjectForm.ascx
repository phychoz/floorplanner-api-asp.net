<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Floorplanner.Web.Models.Entity.Project>" %>
<%= Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.") %>
<% using (Html.BeginForm())
   {%>
<fieldset>
    <legend>Fields</legend>
    <p>
        <label for="Description">
            Description:</label>
        <%= Html.TextBox("Description") %>
        <%= Html.ValidationMessage("Description", "*") %>
    </p>
    <p>
        <label for="ExternalIdentifier">
            External Identifier:</label>
        <%= Html.TextBox("ExternalIdentifier") %>
        <%= Html.ValidationMessage("ExternalIdentifier", "*") %>
    </p>
    <p>
        <label for="Name">
            Name:</label>
        <%= Html.TextBox("Name") %>
        <%= Html.ValidationMessage("Name", "*") %>
    </p>
    <p>
        <label for="FloorsCount">
            Floors Count:</label>
        <select id="NumberOfFloors" name="NumberOfFloors">
            <% for (var i = 2; i < 20; i++)
               {%>
            <option value="<%= i %>">
                <%= i %>
            </option>
            <%} %>
        </select>
    </p>
    <p id="inputBoxes">
    </p>

    <script type="text/javascript" src="../../Scripts/jquery-1.3.2-vsdoc.js"></script>

    <script type="text/javascript">
        $("#NumberOfFloors").change(BuildFloorTextBoxes);

        $(document).ready(BuildFloorTextBoxes);

        function BuildFloorTextBoxes() {
            var numberOfFloors = parseInt($("#NumberOfFloors").val());
            var str = "";
            for (var i = 1; i < numberOfFloors + 1; i++) {
                str += ("<p><label for=\"Floor" + i + "\">Name of Floor #" + i + "</label><input type=\"text\" id=\"Floor" + i + "\" name=\"Floor" + i + "\" /><label for=\"Level" + i + "\">Level</label><input type=\"text\" id=\"Level" + i + "\" name=\"Level" + i + "\" /><label for=\"Height" + i + "\">Height</label><input type=\"text\" id=\"Height" + i + "\" name=\"Height" + i + "\" /></p>");
            }
            $("#inputBoxes").html(str);
        };
        
    </script>

    <p>
        <input type="submit" value="Save" />
    </p>
</fieldset>
<% } %>
<div>
    <%=Html.ActionLink("Back to List", "Index") %>
</div>
