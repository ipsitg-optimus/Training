<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="EntityFrameworkApp.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%;">
        <tr>
            <td style="width:25%;">&nbsp;</td>
            <td style="width:25%;"><h2>Add User</h2></td>
            <td style="width:25%;">&nbsp;</td>
            <td style="width:25%;">&nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>User ID</td>
            <td>
                <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>Age</td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>User Type</td>
            <td>
                <asp:DropDownList ID="ddlUserType" runat="server">
                    <asp:ListItem Value="0">Admin</asp:ListItem>
                    <asp:ListItem Value="1">Normal</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        
    </table>

</asp:Content>
