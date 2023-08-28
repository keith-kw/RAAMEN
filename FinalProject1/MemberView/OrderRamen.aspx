<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="FinalProject1.MemberView.OrderRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="OrderRamenBtn" runat="server" Text="Order Ramen" Onclick="OrderRamenBtn_Click"/>

            <asp:Button ID="HistoryBtn" runat="server" Text="History" Onclick="HistoryBtn_Click"/>

            <asp:Button ID="MemberProfileBtn" runat="server" Text="Profile" Onclick="MemberProfileBtn_Click"/>

            <asp:Button ID="LogoutBtn" runat="server" Text="Logout" Onclick="LogoutBtn_Click"/>
        </div>
        <h1>Order Ramen</h1>
        <div>
            <asp:GridView ID="OrderRamenMenu" runat="server" AutoGenerateColumns="false" OnRowCommand="OrderRamenMenu_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Ramen Name" />
                    <asp:BoundField DataField="MeatName" HeaderText="Meat" />
                    <asp:BoundField DataField="Broth" HeaderText="Broth" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:ButtonField CommandName="Select" Text="Add to Cart" ButtonType="Button" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            
            <asp:GridView ID="OrderCart" runat="server" AutoGenerateColumns="false" OnRowCommand="OrderCart_RowCommand">
                <Columns>
                    <asp:BoundField DataField="RamenName" HeaderText="Ramen Name" />
                    <asp:BoundField DataField="MeatName" HeaderText="Meat" />
                    <asp:BoundField DataField="Broth" HeaderText="Broth" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:ButtonField CommandName="Select" Text="Remove" ButtonType="Button" />
                </Columns>
            </asp:GridView>
            <br />

            <asp:Button ID="BuyBtn" runat="server" Text="Order Cart" OnClick="BuyBtn_Click"/>
            <asp:Button ID="ClearAllBtn" runat="server" Text="Clear All" OnClick="ClearAllBtn_Click"/>
            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click"/>
        </div>
    </form>
</body>
</html>
