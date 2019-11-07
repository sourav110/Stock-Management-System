<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CategorySetupUi.aspx.cs" Inherits="StockManagementSystemWebApp.PL.CategorySetupUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Category Setup</h2>

    <div class="form-group">
        <label for="inputCategoryName">Name</label>
        <input type="text" class="form-control" id="inputCategoryName" runat="server" placeholder="Enter Category Name" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="inputCategoryName" ForeColor="red" ErrorMessage="Name Can't be empty"></asp:RequiredFieldValidator>
    </div>

    <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" />

</asp:Content>
