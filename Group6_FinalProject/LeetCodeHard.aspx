<!--
# Name: Shelby Sash
# email: sashsk@mail.uc.edu
# Assignment Title: Final Project
# Due Date: April 23, 2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This hard level leet code problem creates 2 arrays and finds the median between them. 
# Citations:  https://www.geeksforgeeks.org/median-two-sorted-arrays-different-sizes-ologminn-m/ , https://chat.openai.com/ , https://stackoverflow.com/questions/10180930/asp-net-open-new-webform-on-click-of-button
# Anything else that's relevant: N/A
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeetCodeHard.aspx.cs" Inherits="Group6_FinalProject.LeetCodeHard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDescription" runat="server" 
                Text="Given two arrays, A and B, return the median of the two sorted arrays."></asp:Label><br/><br />
            <asp:Label ID="lblArrayA" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblArrayB" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblMedian" runat="server" Text=""></asp:Label> 
        </div>
    </form>
</body>
</html>
