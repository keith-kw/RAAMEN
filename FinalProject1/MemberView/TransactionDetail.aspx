<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="FinalProject1.MemberView.TransactionDetail" %>

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
        <h1>Transaction Detail</h1>
        <div>
            <asp:Label ID="memberLbl" runat="server" Text=""></asp:Label>

            <asp:GridView ID="HistoryDetail" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="RamenName" HeaderText="Ramen Name" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            </Columns>
        </asp:GridView>

            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click"/>
        </div>
    </form>
</body>
</html>
