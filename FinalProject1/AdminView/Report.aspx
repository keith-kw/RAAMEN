<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="FinalProject1.AdminView.Report" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <CR:CrystalReportViewer ID="ReportViewer" runat="server" AutoDataBind="true" />
        </div>
        <div>
            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click"/>
        </div>
    </form>
</body>
</html>
