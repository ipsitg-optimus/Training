<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteStudent.aspx.cs" Inherits="WebApplication1.DeleteStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 34px;
        }

        .auto-style2 {
            width: 10%;
        }

        .auto-style3 {
            height: 34px;
            width: 10%;
        }
    </style>
    <script>
        var xmlHttp = new XMLHttpRequest();
        function RightClick() {
            var right = document.getElementById("lbRight");
            var left = document.getElementById("lbLeft");
            var option = document.createElement("option");
            option.text = left.options[left.selectedIndex].text;
            option.value = left.value;
            right.add(option);
            left.remove(left.selectedIndex);
            xmlHttp.open("GET", "Get.aspx?roll_number=" + option.value, true);
            xmlHttp.send(null);
        }

        function LeftClick() {
            var right = document.getElementById("lbRight");
            var left = document.getElementById("lbLeft");
            var option = document.createElement("option");
            option.text = right.options[right.selectedIndex].text;
            option.value = right.value;
            left.add(option);
            right.remove(right.selectedIndex);
            xmlHttp.open("GET", "Remove.aspx?roll_number=" + option.value, true);
            xmlHttp.send(null);
        }

        function DeleteConfirmation() {
            return confirm("Are you sure you want to delete this user?");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td style="width: 80%; text-align: center">
                <h2>Delete Students</h2>
            </td>
            <td style="width: 10%"></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style1">Select Stream&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlStream" runat="server" ClientIDMode="Static" AutoPostBack="True" OnSelectedIndexChanged="ddlStream_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style1">
                <table style="width: 100%;">
                    <tr>
                        <td style="width: 33%;">
                            <asp:ListBox ID="lbLeft" runat="server" ClientIDMode="Static" Width="200px"></asp:ListBox>
                        </td>
                        <td style="width: 33%;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <input id="btnLeft" type="button" value="<--" onclick="LeftClick()" /><br />
                            <br />
                            <br />
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <input id="btnRight" type="button" value="-->" onclick="RightClick()" /></td>
                        <td style="width: 33%;">
                            <asp:ListBox ID="lbRight" runat="server" ClientIDMode="Static" Width="200px"></asp:ListBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" OnClientClick="if ( ! DeleteConfirmation()) return false;" />
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="auto-style1"></td>
        </tr>
    </table>
</asp:Content>
