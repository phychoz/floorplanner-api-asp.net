<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Floorplanner.Web.Models.Entity.Project>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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
                <option value="<%= i %>" "<%= (Model.Floors.Floors.Count() == i ? "selected=\"true\"" : string.Empty) %>">
                    <%= i %>
                </option>
                <%} %>
            </select>
        </p>
        <p id="inputBoxes">
        </p>

        <script type="text/javascript" src="../../Scripts/jquery-1.3.2-vsdoc.js"></script>

        <%
            for (var i = 1; i < Model.Floors.Floors.Count() + 1; i++)
            {%>
        <input type="hidden" value="<%= Model.Floors.Floors[i-1].Name %>" id="Floor<%= i%>Value" />
        <input type="hidden" value="<%= Model.Floors.Floors[i-1].Level %>" id="Level<%= i%>Value" />
        <input type="hidden" value="<%= Model.Floors.Floors[i-1].Height %>" id="Height<%= i%>Value" />
        <%}
        %>

        <script type="text/javascript">
            $("#NumberOfFloors").change(BuildFloorTextBoxes);

            $(document).ready(BuildFloorTextBoxes);

            function BuildFloorTextBoxes() {
                var numberOfFloors = parseInt($("#NumberOfFloors").val());
                var str = "";
                for (var i = 1; i < numberOfFloors + 1; i++) {
                    str += ("<p><label for=\"Floor" + i + "\">Name of Floor #" + i + "</label><input type=\"text\" id=\"Floor" + i + "\" name=\"Floor" + i + "\" value=\"" + $("#Floor" + i + "Value").val() + "\" /><label for=\"Level" + i + "\">Level</label><input type=\"text\" id=\"Level" + i + "\" name=\"Level" + i + "\" value=\"" + $("#Level" + i + "Value").val() + "\" /><label for=\"Height" + i + "\">Height</label><input type=\"text\" id=\"Height" + i + "\" name=\"Height" + i + "\" value=\"" + $("#Height" + i + "Value").val() + "\" /></p>");
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsContentPlaceHolder" runat="server">

    <script type="text/javascript" src="/Scripts/jquery-1.3.2.js"></script>

</asp:Content>
