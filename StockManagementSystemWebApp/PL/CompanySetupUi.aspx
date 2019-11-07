<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CompanySetupUi.aspx.cs" Inherits="StockManagementSystemWebApp.PL.CompanySetupUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Company Setup</h2>

    <div class="form-group">
        <label for="inputCompanyName">Name</label>
        <input type="text" class="form-control" id="inputCompanyName" runat="server" placeholder="Enter Company Name" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="inputCompanyName" ForeColor="red" ErrorMessage="Name Can't be empty"></asp:RequiredFieldValidator>
    </div>

    <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" />
</asp:Content>
