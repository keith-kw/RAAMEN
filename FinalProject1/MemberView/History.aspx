<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="FinalProject1.MemberView.History" %>

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
        <h1>History</h1>
        <div>
            <asp:GridView ID="OrderHistory" runat="server" AutoGenerateColumns="false" OnRowCommand="OrderHistory_RowCommand">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="Header ID"/>
                    <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" />
                    <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                    <asp:BoundField DataField="Date" HeaderText="Date"/>
                    <asp:ButtonField CommandName="Select" Text="Detail" ButtonType="Button" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click"/>
        </div>
    </form>
</body>
</html>
