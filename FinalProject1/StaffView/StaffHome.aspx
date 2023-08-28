<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffHome.aspx.cs" Inherits="FinalProject1.StaffView.StaffHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>This is Staff Page</h1>
        <div>
             <asp:Button ID="manageBtn" runat="server" Text="Manage Ramen" OnClick="manageBtn_Click"/>

            <asp:Button ID="queueBtn" runat="server" Text="Order Queue" OnClick="queueBtn_Click"/>

            <asp:Button ID="profileBtn" runat="server" Text="Profile" OnClick="profileBtn_Click"/>
            
            <asp:Button ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click"/>
            <br />
            <br />

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
