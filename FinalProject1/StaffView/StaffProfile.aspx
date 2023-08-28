<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffProfile.aspx.cs" Inherits="FinalProject1.StaffView.StaffProfile" %>

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
        <h1>Profile</h1>
        <div>
            <asp:Label ID="userLbl" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="userTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="genderList" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />

            <asp:Label ID="passLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="passTxt" runat="server" Textmode="Password"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="updateLbl" runat="server" Text=""></asp:Label>
            <asp:Button ID="updateBtn" runat="server" Text="Update Profile" OnClick="updateBtn_Click"/>

            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click"/>
        </div>
    </form>
</body>
</html>
