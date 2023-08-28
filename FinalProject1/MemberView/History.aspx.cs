using FinalProject1.Controller;
using FinalProject1.Model;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static FinalProject1.StaffView.OrderQueue;

namespace FinalProject1.MemberView
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowHistory();
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

        private void ShowHistory()
        {
            string username = (string)Session["User"];
            var check = UserController.CheckRole(username);
            if(check == 1)
            {
                List<Header> headers = TransactionHeaderRepository.GetHeaders();
                OrderHistory.DataSource = headers.Select(x => new
                {
                    x.ID,
                    x.CustomerID,
                    CustomerName = UserRepository.GetUserByID(x.CustomerID),
                    x.Date
                }).ToList();
                OrderHistory.DataBind();
            }
            else
            {
                int id = UserRepository.GetUserID(username);
                List<Header> headers = TransactionHeaderRepository.GetHeadersByID(id);

                OrderHistory.DataSource = headers.Select(x => new
                {
                    x.ID,
                    x.CustomerID,
                    CustomerName = UserRepository.GetUserByID(x.CustomerID),
                    x.Date
                }).ToList();
                OrderHistory.DataBind();
            }
        }

        protected void OrderHistory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = OrderHistory.Rows[index];
                int headerID = Convert.ToInt32(row.Cells[0].Text);

                string url = "TransactionDetail.aspx?HeaderID=" + headerID;
                Response.Redirect(url);
            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            string username = (string)Session["User"];
            var id = UserController.CheckRole(username);
            if (id == 1)
            {
                Response.Redirect("~/AdminView/AdminHome.aspx");
            }
            else if (id == 3)
            {

                Response.Redirect("MemberHome.aspx");
            }
        }
    }
}