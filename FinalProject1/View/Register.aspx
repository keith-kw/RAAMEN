<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FinalProject1.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register Page</h1>
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

            <asp:Label ID="passLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="passTxt" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="confirmLbl" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="confirmTxt" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="regisLbl" runat="server" Text=""></asp:Label>
            <asp:Button ID="registBtn" runat="server" Text="Register" OnClick="registBtn_Click"/>

            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click"/>
        </div>
    </form>
</body>
</html>
