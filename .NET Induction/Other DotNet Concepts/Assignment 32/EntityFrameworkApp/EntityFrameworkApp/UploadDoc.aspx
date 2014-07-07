<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="UploadDoc.aspx.cs" Inherits="EntityFrameworkApp.UploadDoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Please select file to upload<br />
<asp:FileUpload ID="fuplFile1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<asp:Button ID="btnUpload" runat="server" OnClick="Button1_Click" Text="Upload" />
<br />
</asp:Content>
