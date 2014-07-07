<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="WebApplication1.EditStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td style="width: 10%">&nbsp;</td>
            <td style="width: 80%;text-align:center">
                <h2>Edit Student</h2>
            </td>
            <td style="width: 10%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <asp:TextBox ID="txtRollSearch" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td style="width:33%">Name</td>
                        <td style="width:33%">
                            <asp:TextBox ID="txtName" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        <td style="width:33%">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Required" Font-Bold="True" Font-Size="Small" ForeColor="Red" ValidationGroup="form1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Father Name</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtFatherName" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        <td class="auto-style1">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFatherName" ErrorMessage="Required" Font-Bold="True" Font-Size="Small" ForeColor="Red" ValidationGroup="form1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Gender</td>
                        <td>
                            <asp:TextBox ID="txtGender" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtGender" ErrorMessage="Required" Font-Bold="True" Font-Size="Small" ForeColor="Red" ValidationGroup="form1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Age</td>
                        <td>
                            <asp:TextBox ID="txtAge" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Not a valid age" Font-Bold="True" Font-Size="Small" ForeColor="Red" MaximumValue="40" MinimumValue="4" Type="Integer" ValidationGroup="form1"></asp:RangeValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAge" ErrorMessage="Required" Font-Bold="True" Font-Size="Small" ForeColor="Red" ValidationGroup="form1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>State</td>
                        <td>
                            <asp:DropDownList ID="ddlState" runat="server" Enabled="False">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlState" ErrorMessage="Required" Font-Bold="True" Font-Size="Small" ForeColor="Red" ValidationGroup="form1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Stream</td>
                        <td>
                            <asp:DropDownList ID="ddlStream" runat="server" Enabled="False">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlStream" ErrorMessage="Required" Font-Bold="True" Font-Size="Small" ForeColor="Red" ValidationGroup="form1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnUpdate" runat="server" Enabled="False" Text="Update" ValidationGroup="form1" OnClick="btnUpdate_Click" />
                        </td>
                        <td>
                            <asp:Label ID="lblErrorMessage" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="Red" Text="Some error ocurred." Visible="False"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
