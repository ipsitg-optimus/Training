<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="EntityFrameworkApp.ViewDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%;">
        <tr>
            <td style="width:33%;">&nbsp;</td>
            <td style="width:33%;">User details</td>
            <td style="width:33%;">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="grdView" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="User ID" DataSourceID="datasource1" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="User ID" HeaderText="User ID" ReadOnly="True" SortExpression="User ID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                        <asp:BoundField DataField="User Type" HeaderText="User Type" ReadOnly="True" SortExpression="User Type" />
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
                <asp:SqlDataSource ID="datasource1" runat="server" ConnectionString="<%$ ConnectionStrings:userConnectionString %>" SelectCommand="select user_id as 'User ID', name as 'Name',age as 'Age', (CASE when user_type=0 then 'Admin' else 'Normal' end)as 'User Type' from user_details"></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
