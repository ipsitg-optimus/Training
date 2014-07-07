<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EntityFrameworkApp.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Login here</h2>
<p>&nbsp;</p>
<p>UserID
    <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
</p>

</asp:Content>
