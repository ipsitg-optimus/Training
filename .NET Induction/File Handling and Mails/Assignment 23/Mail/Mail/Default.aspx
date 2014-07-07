<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mail.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Path of the folder.&nbsp;
    <asp:TextBox ID="txtPath" runat="server"></asp:TextBox>
    <asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="Red" Text="Invalid directory" Visible="False"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
</asp:Content>
