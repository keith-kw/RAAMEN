<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalProject1.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login Page</h1>
        <div>
            <asp:Label ID="userLbl" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="userTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="passLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="passTxt" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="rememberLbl" runat="server"></asp:Label>
            <asp:CheckBox ID="rememberCheckBox" runat="server" Text="Remember Me"/>
            <br />
            <br />

            <asp:Label ID="loginLbl" runat="server" Text=""></asp:Label>
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click"/>

            <asp:Label ID="registerLbl" runat="server" Text=""></asp:Label>
            <asp:Button ID="regisBtn" runat="server" Text="Register" OnCLick="regisBtn_Click"/>
        </div>
    </form>
</body>
</html>
