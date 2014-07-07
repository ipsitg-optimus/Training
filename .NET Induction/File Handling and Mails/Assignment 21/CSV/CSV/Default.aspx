<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSV.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:FileUpload ID="fileUpload" runat="server" />
    <br />
    <asp:Button ID="btnUpload" runat="server" Text="Save Students To DB" OnClick="btnUpload_Click" />
</asp:Content>
