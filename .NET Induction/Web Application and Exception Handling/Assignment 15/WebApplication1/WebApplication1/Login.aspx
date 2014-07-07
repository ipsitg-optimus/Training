<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        Login here</h2>
<p>
        Username<asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="lblUsernameValidator" runat="server" ErrorMessage="Required" ControlToValidate="txtUname" Font-Bold="True" Font-Size="Small" ForeColor="Red" ValidationGroup="form"></asp:RequiredFieldValidator>
</p>
<p>
        Password<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="lblPasswordValidator" runat="server" ErrorMessage="Required" ControlToValidate="txtPassword" Font-Bold="True" Font-Size="Small" ForeColor="Red" ValidationGroup="form"></asp:RequiredFieldValidator>
</p>
<p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="form" />
</p>
</asp:Content>
