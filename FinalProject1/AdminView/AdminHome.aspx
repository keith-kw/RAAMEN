﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="FinalProject1.AdminView.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>This is Admin Home</h1>
        <div>
            <asp:Button ID="ManageRamenBtn" runat="server" Text="Manage Ramen" OnClick="ManageRamenBtn_Click"/>

            <asp:Button ID="OrderQueueBtn" runat="server" Text="Order Queue" OnClick="OrderQueueBtn_Click"/>

            <asp:Button ID="OrderRamenBtn" runat="server" Text="Order Ramen" OnClick="OrderRamenBtn_Click"/>

            <asp:Button ID="HistoryBtn" runat="server" Text="History" OnClick="HistoryBtn_Click"/>

            <asp:Button ID="AllTransactionBtn" runat="server" Text="View All Transaction" OnClick="AllTransactionBtn_Click"/>

            <asp:Button ID="ReportBtn" runat="server" Text="Report" OnClick="ReportBtn_Click"/>

            <asp:Button ID="ViewUserBtn" runat="server" Text="View User" OnClick="ViewUserBtn_Click"/>

            <asp:Button ID="ProfileBtn" runat="server" Text="Profile" OnClick="ProfileBtn_Click"/>

            <asp:Button ID="LogoutBtn" runat="server" Text="Logout" OnClick="LogoutBtn_Click"/>
        </div>
    </form>
</body>
</html>
