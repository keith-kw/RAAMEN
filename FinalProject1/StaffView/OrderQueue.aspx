<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="FinalProject1.StaffView.OrderQueue" %>

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
        <h1>Unhandled Transactions</h1>
        <div>
            <asp:GridView ID="OrderList" runat="server" AutoGenerateColumns="false" OnRowCommand="OrderList_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                    <asp:BoundField DataField="OrderStatus" HeaderText="Order Status" />
                    <asp:BoundField DataField="Date" HeaderText="Date"/>
                    <asp:ButtonField CommandName="Select" Text="Handle" ButtonType="Button" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <br />
        <h1>Handled Transactions</h1>
        <div>
            <asp:GridView ID="HandledList" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="CustomerID" HeaderText="Customer Name" />
                    <asp:BoundField DataField="Date" HeaderText="Date"></asp:BoundField>
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click"/>
        </div>
    </form>
</body>
</html>
