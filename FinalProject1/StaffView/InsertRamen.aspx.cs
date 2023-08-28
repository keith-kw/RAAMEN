using FinalProject1.Controller;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject1.StaffView
{
    public partial class InsertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowRamen();
        }

        private void ShowRamen()
        {
            List<Object> ramens = RamenRepository.GetRamens();
            GridView1.DataSource = ramens;
            GridView1.DataBind();
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string meat = meatList.SelectedValue;
            string broth = brothTxt.Text;
            string price = priceTxt.Text;
            insertLbl.Text = RamenController.CheckInsertRamen(name, meat, broth, price);
            ShowRamen();
            nameTxt.Text = brothTxt.Text = priceTxt.Text = "";
        }

        protected void manageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen.aspx");
        }

        protected void manage_Click(object sender, EventArgs e)
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