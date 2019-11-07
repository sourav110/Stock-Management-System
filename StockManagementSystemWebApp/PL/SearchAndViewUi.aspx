<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchAndViewUi.aspx.cs" Inherits="StockManagementSystemWebApp.PL.SearchAndViewUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Search and View Item Summary</h2>

    <div class="form-group">
        <label for="inputCompany">Company</label>
        <asp:DropDownList ID="ddlCompany" class="form-control" runat="server"></asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="inputCategory">Category</label>
        <asp:DropDownList ID="ddlCategory" class="form-control" runat="server"></asp:DropDownList>
    </div>
    <asp:Button ID="searchButton" class="btn btn-primary" runat="server" Text="Search" />
    <br />

    <asp:GridView ID="companyGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="SL">
                    <ItemTemplate>
                        <%#Container.DataItemIndex +1 %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Item">
                    <ItemTemplate>
                        <%--<%DataItemContainer.DataBind(); %>--%>
                        <%#Eval("ItemName") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Company">
                    <ItemTemplate>
                        <%--<%DataItemContainer.DataBind(); %>--%>
                        <%#Eval("CompanyName") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Category">
                    <ItemTemplate>
                        <%--<%DataItemContainer.DataBind(); %>--%>
                        <%#Eval("CategoryName") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Available Quantity">
                    <ItemTemplate>
                        <%--<%DataItemContainer.DataBind(); %>--%>
                        <%#Eval("Quantity") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="ReorderLevel">
                    <ItemTemplate>
                        <%--<%DataItemContainer.DataBind(); %>--%>
                        <%#Eval("ReorderLevel") %>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
</asp:Content>
