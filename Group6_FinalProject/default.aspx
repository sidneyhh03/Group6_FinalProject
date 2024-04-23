<!--
# Name: Shelby Sash, Sidney Huschart, Caitlin Hutchins
# email: sashsk@mail.uc.edu
# Assignment Title: Final Project
# Due Date: April 23, 2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Creates web forms for easy, medium, hard leet code problems and displays them when a button is clicked. 
# Citations: listed in the individual web forms
# Anything else that's relevant: N/A
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Group6_FinalProject._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnRedirect" OnClick="btnRedirect_Click" runat="server" Text="Go to Hard Problem"  /><br />
            <asp:Button ID="btnRedirect2" OnClick="btnRedirect2_Click" runat="server" Text="Go to Medium Problem"  /><br />
            <asp:Button ID="btnRedirect3" OnClick="btnRedirect3_Click" runat="server" Text="Go to Easy Problem"  /><br />
        </div>
    </form>
</body>
</html>
