<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewSalesUi.aspx.cs" Inherits="StockManagementSystemWebApp.PL.ViewSalesUi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>View Sales between two dates</h2>

    <div class="form-group">
        <label for="inputFromDate">From Date</label>
        
        <input type="text" data-provide="datepicker" class="form-control" id="inputItemName" runat="server"/>
        <%--<asp:DropDownList ID="ddlCompany" class="form-control" runat="server"></asp:DropDownList>--%>
    </div>

    <div class="form-group">
        <label for="inputToDate">To Date</label>

        <%--<asp:DropDownList ID="ddlCategory" class="form-control" runat="server"></asp:DropDownList>--%>
    </div>
    <asp:Button ID="searchButton" class="btn btn-primary" runat="server" Text="Search" />
    <br />
</asp:Content>
