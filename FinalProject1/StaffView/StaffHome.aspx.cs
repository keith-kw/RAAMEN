using FinalProject1.Model;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject1.StaffView
{
    public partial class StaffHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowUser();
        }

        private void ShowUser()
        {
            List<User> customers = UserRepository.GetCustomer();
            GridView1.DataSource = customers;
            GridView1.DataBind();
        }

        protected void manageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen.aspx");
        }

        protected void queueBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderQueue.aspx");
        }

        protected void profileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffProfile.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Clear();
            Response.Redirect("~/View/Login.aspx");
        }
    }
}