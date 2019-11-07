<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemSetupUi.aspx.cs" Inherits="StockManagementSystemWebApp.PL.ItemSetupUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Item Setup</h2>

    <div class="form-group">
        <label for="inputCategory">Category</label>
        <asp:DropDownList ID="ddlCategory" class="form-control" runat="server"></asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="inputCompany">Company</label>
        <asp:DropDownList ID="ddlCompany" class="form-control" runat="server"></asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="inputItemName">Name</label>
        <input type="text" class="form-control" id="inputItemName" runat="server" placeholder="Enter Item Name" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="inputItemName" ForeColor="red" ErrorMessage="Name Can't be empty"></asp:RequiredFieldValidator>
    </div>

    <div class="form-group">
        <label for="inputReorderLevel">Reorder Level</label>
        <input type="text" class="form-control" id="inputReorderLevel" runat="server" value="0" />
    </div>

    <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click" />
    <br />
    <asp:Label ID="messageLabel" runat="server"></asp:Label>
    
</asp:Content>
