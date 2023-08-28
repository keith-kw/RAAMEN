<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberHome.aspx.cs" Inherits="FinalProject1.MemberView.MemberHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h1>Member Home</h1>
        <div>
                <asp:Button ID="OrderRamenBtn" runat="server" Text="Order Ramen" Onclick="OrderRamenBtn_Click"/>

                <asp:Button ID="HistoryBtn" runat="server" Text="History" Onclick="HistoryBtn_Click"/>

                <asp:Button ID="MemberProfileBtn" runat="server" Text="Profile" Onclick="MemberProfileBtn_Click"/>

                <asp:Button ID="LogoutBtn" runat="server" Text="Logout" Onclick="LogoutBtn_Click"/>
        </div>
    </form>
</body>
</html>
