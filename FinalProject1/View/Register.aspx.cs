using FinalProject1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject1.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registBtn_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string email = emailTxt.Text;
            string gender = genderList.SelectedValue;
            string password = passTxt.Text;
            string confirm = confirmTxt.Text;
            regisLbl.Text = UserController.RegisterCheck(username, email, gender, password, confirm);
            
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}