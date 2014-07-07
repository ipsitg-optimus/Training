<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="WebApplication1.AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td style="width: 33%">&nbsp;</td>
            <td style="width: 33%; text-align: center">
                <h2>Add Student</h2>
            </td>
            <td style="width: 33%">&nbsp;</td>
        </tr>
        <tr>
            <td>Roll Number</td>
            <td>
                <asp:TextBox ID="txtRollNumber" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="lblRollNumberValidator" runat="server" ErrorMessage="Required" Font-Size="Small" ForeColor="Red" ControlToValidate="txtRollNumber" ValidationGroup="form1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="lblNameValidator" runat="server" ErrorMessage="Required" Font-Size="Small" ForeColor="Red" ControlToValidate="txtName" ValidationGroup="form1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Father&#39;s Name</td>
            <td>
                <asp:TextBox ID="txtFatherName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="lblFatherNameValidator" runat="server" ErrorMessage="Required" Font-Size="Small" ForeColor="Red" ControlToValidate="txtFatherName" ValidationGroup="form1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="lblGenderValidator" runat="server" ErrorMessage="Required" Font-Size="Small" ForeColor="Red" ControlToValidate="txtGender" ValidationGroup="form1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Age</td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="lblAgeRangeValidator" runat="server" ErrorMessage="Not a valid age." Font-Size="Small" ForeColor="Red" ControlToValidate="txtAge" MaximumValue="40" MinimumValue="4" ValidationGroup="form1" Style="position: absolute;" Type="Integer"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="lblAgeValidator" runat="server" ErrorMessage="Required" Font-Size="Small" ForeColor="Red" ControlToValidate="txtAge" ValidationGroup="form1" Style="position: absolute;"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Stream</td>
            <td>
                <asp:DropDownList ID="ddlStream" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="lblStreamValidator" runat="server" ErrorMessage="Required" Font-Size="Small" ForeColor="Red" ControlToValidate="ddlStream" InitialValue="null" ValidationGroup="form1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>State</td>
            <td>
                <asp:DropDownList ID="ddlState" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="lblStateValidator" runat="server" ErrorMessage="Required" Font-Size="Small" ForeColor="Red" ControlToValidate="ddlState" InitialValue="null" ValidationGroup="form1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Add" ValidationGroup="form1" OnClick="btnAdd_Click" />
            </td>
            <td>
                <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Text="Some Error Occurred." Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
