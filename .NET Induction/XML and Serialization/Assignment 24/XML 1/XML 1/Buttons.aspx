<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buttons.aspx.cs" Inherits="XML_1.Buttons" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Node" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFirstChild" runat="server" OnClick="btnFirstChild_Click" Text="View First Child" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnInsertBefore" runat="server" OnClick="btnInsertBefore_Click" Text="Insert Before Node" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRemoveNode" runat="server" OnClick="btnRemoveNode_Click" Text="Remove Node" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnChildNode" runat="server" OnClick="btnChildNode_Click" Text="View Child Nodes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnTotalNode" runat="server" OnClick="btnTotalNode_Click" Text="Total Nodes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReplaceChild" runat="server" OnClick="btnReplaceChild_Click" Text="Replace Child" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
        <asp:Panel ID="pnlPanel" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
