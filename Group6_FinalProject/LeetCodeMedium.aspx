<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeetCodeMedium.aspx.cs" Inherits="Group6_FinalProject.LeetCodeMedium" %>

<!DOCTYPE html>
<!--
# Name: Caitlin Hutchins
# email: hutchicu@mail.uc.edu
# Assignment Title: Final
# Due Date:4/23/24
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This project is our final
# Citations: leetcode
# Anything else that's relevant:
-->

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="lblDescription" runat="server" Text="This is an example of a medium level problem on leet code called Integer to Roman."></asp:Label>
            <asp:Table ID="tblIntegerToRomanNum" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableCell>
                        <asp:Label ID="lblSymbol" runat="server" Text="Symbol"> </asp:Label>
                        <br />
                        <asp:Label ID="I" runat="server" Text="I"></asp:Label>
                        <br />
                        <asp:Label ID="V" runat="server" Text="V"></asp:Label>
                        <br />
                        <asp:Label ID="X" runat="server" Text="X"></asp:Label>
                        <br />
                        <asp:Label ID="L" runat="server" Text="L"></asp:Label>
                        <br />
                        <asp:Label ID="C" runat="server" Text="C"></asp:Label>
                        <br />
                        <asp:Label ID="D" runat="server" Text="D"></asp:Label>
                        <br />
                        <asp:Label ID="M" runat="server" Text="M"></asp:Label>

                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblValue" runat="server" Text="Value"></asp:Label>
                        <br />
                        <asp:Label ID="lblOne" runat="server" Text="1"></asp:Label>
                        <br />
                        <asp:Label ID="lblFive" runat="server" Text="5"></asp:Label>
                        <br />
                        <asp:Label ID="lblTen" runat="server" Text="10"></asp:Label>
                        <br />
                        <asp:Label ID="lblFifty" runat="server" Text="50"></asp:Label>
                        <br />
                        <asp:Label ID="lblOneHundred" runat="server" Text="100"></asp:Label>
                        <br />
                        <asp:Label ID="lblFiveHundred" runat="server" Text="500"></asp:Label>
                        <br />
                        <asp:Label ID="lblOneThousand" runat="server" Text="1000"></asp:Label>
                    </asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
