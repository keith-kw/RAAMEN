<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="FinalProject1.StaffView.UpdateRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="manage" runat="server" Text="Manage Ramen" OnClick="manage_Click"/>

            <asp:Button ID="queueBtn" runat="server" Text="Order Queue" OnClick="queueBtn_Click"/>

            <asp:Button ID="profileBtn" runat="server" Text="Profile" OnClick="profileBtn_Click"/>
            
            <asp:Button ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click"/>
        </div>
         <h1>Update Ramen</h1>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <br />

            <asp:Label ID="idLbl" runat="server" Text="Ramen ID"></asp:Label>
            <asp:TextBox ID="idTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="nameLbl" runat="server" Text="Ramen Name"></asp:Label>
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="dropLbl" runat="server" Text="Meat"></asp:Label>
            <asp:DropDownList ID="meatList" runat="server">
                <asp:ListItem>Beef</asp:ListItem>
                <asp:ListItem>Chicken</asp:ListItem>
                <asp:ListItem>Pork</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />

            <asp:Label ID="brothLbl" runat="server" Text="Broth"></asp:Label>
            <asp:TextBox ID="brothTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="priceLbl" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="updateLbl" runat="server" Text=""></asp:Label>
            <asp:Button ID="updateBtn" runat="server" Text="Update Ramen" OnClick="updateBtn_Click"/>

            <asp:Button ID="manageBtn" runat="server" Text="Back" OnClick="manageBtn_Click"/>
        </div>
    </form>
</body>
</html>
