<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="WebApplication1.AboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton ID="lnkHome"  runat="server" PostBackUrl="~/Welcome.aspx">Home</asp:LinkButton>
    <br />
    <br />
    <br />
    <asp:TreeView ID="tvTrial" runat="server" ExpandDepth="0" ImageSet="Msdn" NodeIndent="10">
        <HoverNodeStyle BackColor="#CCCCCC" BorderColor="#888888" BorderStyle="Solid" Font-Underline="True" />
        <Nodes>
            <asp:TreeNode Text="Root 1" Value="Root 1">
                <asp:TreeNode Text="Child 1" Value="Child 1">
                    <asp:TreeNode Text="Leaf 1" Value="Leaf 1"></asp:TreeNode>
                    <asp:TreeNode Text="Leaf 2" Value="Leaf 2"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="Child 2" Value="Child 2"></asp:TreeNode>
                <asp:TreeNode Text="Child 3" Value="Child 3"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="Root 2" Value="Root2"></asp:TreeNode>
            <asp:TreeNode Text="Root 3" Value="Root 3"></asp:TreeNode>
        </Nodes>
        <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="1px" VerticalPadding="2px" />
        <ParentNodeStyle Font-Bold="False" />
        <SelectedNodeStyle BackColor="White" BorderColor="#888888" BorderStyle="Solid" BorderWidth="1px" Font-Underline="False" HorizontalPadding="3px" VerticalPadding="1px" />
    </asp:TreeView>
    <br />
    <br />
</asp:Content>
