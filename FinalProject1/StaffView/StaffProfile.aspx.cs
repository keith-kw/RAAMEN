using FinalProject1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject1.StaffView
{
    public partial class StaffProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string email = emailTxt.Text;
            string gender = genderList.SelectedValue;
            string password = passTxt.Text;
            UserController.UpdateCheck(username, email, gender, password);
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            string username = (string)Session["User"];
            var id = UserController.CheckRole(username);
            if (id == 1)
            {
                Response.Redirect("~/AdminView/AdminHome.aspx");
            }
            else if (id == 2)
            {

                Response.Redirect("StaffHome.aspx");
            }
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