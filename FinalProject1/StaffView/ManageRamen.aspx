<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" Inherits="FinalProject1.StaffView.ManageRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="manageBtn" runat="server" Text="Manage Ramen" OnClick="manageBtn_Click"/>

            <asp:Button ID="queueBtn" runat="server" Text="Order Queue" OnClick="queueBtn_Click"/>

            <asp:Button ID="profileBtn" runat="server" Text="Profile" OnClick="profileBtn_Click"/>
            
            <asp:Button ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click"/>
        </div>
        <h1>Manage Ramen</h1>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            <asp:Button ID="insertBtn" runat="server" Text="Insert Ramen" OnClick="insertBtn_Click"/>

            <asp:Button ID="updateBtn" runat="server" Text="Update Ramen" OnClick="updateBtn_Click"/>

            <asp:Button ID="deleteBtn" runat="server" Text="Delete Ramen" OnCLick="deleteBtn_Click"/>

            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click"/>
        </div>
    </form>
</body>
</html>
