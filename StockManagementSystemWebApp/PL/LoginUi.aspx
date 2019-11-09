<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginUi.aspx.cs" Inherits="StockManagementSystemWebApp.LoginUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Log In</h2>

    <div class="form-group">
        <label for="inputUserName">User Name</label>
        <input type="text" class="form-control" id="inputUserName" runat="server" placeholder="Enter User Name" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="inputUserName" ForeColor="red" ErrorMessage="Name Can't be empty"></asp:RequiredFieldValidator>
    </div>

    <div class="form-group">
        <label for="inputPassword">Password</label>
        <input type="password" class="form-control" id="inputPassword" runat="server" placeholder="Enter Passoword" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="inputPassword" ForeColor="red" ErrorMessage="Enter valid password"></asp:RequiredFieldValidator>
    </div>

    <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Login" OnClick="saveButton_Click" />
    <br />
    <asp:Label ID="messageLabel" runat="server"></asp:Label>

</asp:Content>
