using FinalProject1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject1.MemberView
{
    public partial class MemberProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OrderRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderRamen.aspx");
        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("History.aspx");
        }

        protected void MemberProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberProfile.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Clear();
            Response.Redirect("~/View/Login.aspx");
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
            Response.Redirect("MemberHome.aspx");
        }

    }
}