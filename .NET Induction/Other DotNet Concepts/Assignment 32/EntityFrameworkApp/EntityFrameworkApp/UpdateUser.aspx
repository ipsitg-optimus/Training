<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="EntityFrameworkApp.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width:25%;">&nbsp;</td>
            <td style="width:25%;"><h2>Update&nbsp; User</h2></td>
            <td style="width:25%;">&nbsp;</td>
            <td style="width:25%;">&nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>User ID</td>
            <td>
                <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            </td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>Age</td>
            <td>
                <asp:TextBox ID="txtAge" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>User Type</td>
            <td>
                <asp:DropDownList ID="ddlUserType" runat="server" Enabled="False">
                    <asp:ListItem Value="0">Admin</asp:ListItem>
                    <asp:ListItem Value="1">Normal</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnUpdate" runat="server"  Text="Update" Enabled="False" OnClick="btnAdd_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        
    </table>
</asp:Content>
