<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="EntityFrameworkApp.DeleteUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width:25%;">&nbsp;</td>
            <td style="width:25%;"><h2>Delete User</h2></td>
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
                <asp:Button ID="btnDelete" runat="server" OnClick="btnFind_Click" Text="Delete" />
            </td>
        </tr>
  
    </table>
</asp:Content>
