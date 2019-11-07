<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemSetupUi.aspx.cs" Inherits="StockManagementSystemWebApp.PL.ItemSetupUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Item Setup</h2>

    <div class="form-group">
        <label for="inputItemName">Name</label>
        <input type="text" class="form-control" id="inputItemName" runat="server" placeholder="Enter Item Name" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="inputItemName" ForeColor="red" ErrorMessage="Name Can't be empty"></asp:RequiredFieldValidator>
    </div>

    <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" />

</asp:Content>
