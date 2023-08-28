using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject1.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string password = passTxt.Text;
            bool login = UserRepository.CheckUser(username, password);
            if (login)
            {
                if (rememberCheckBox.Checked)
                {
                    HttpCookie cookie = new HttpCookie("Cookie_User");
                    cookie.Value = username;
                    cookie.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(cookie);
                }
                Session["User"] = username;
                var id = UserRepository.GetRole(username);
                if (id == 1)
                {
                    Response.Redirect("~/AdminView/AdminHome.aspx");
                }
                else if (id == 2)
                {
                    Response.Redirect("~/StaffView/StaffHome.aspx");
                }
                else
                {
                    Response.Redirect("~/MemberView/MemberHome.aspx");
                }
            }
            else
            {
                loginLbl.Text = "Wrong Credentials";
            }
        }

        protected void regisBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}