using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject1.AdminView
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ManageRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StaffView/ManageRamen.aspx");
        }

        protected void OrderQueueBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StaffView/OrderQueue.aspx");
        }

        protected void OrderRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MemberView/OrderRamen.aspx");
        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MemberView/History.aspx");
        }

        protected void AllTransactionBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllTransaction.aspx");
        }

        protected void ReportBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }

        protected void ViewUserBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StaffView/StaffProfile.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Clear();
            Response.Redirect("~/View/Login.aspx");
        }
    }
}