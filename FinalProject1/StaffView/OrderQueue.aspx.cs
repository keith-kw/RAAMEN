using FinalProject1.Controller;
using FinalProject1.Handler;
using FinalProject1.Model;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static FinalProject1.MemberView.OrderRamen;

namespace FinalProject1.StaffView
{
    public partial class OrderQueue : System.Web.UI.Page
    {
        public class RamenQueue
        {
            public string CustomerName { get; set; }
            public List<Cart> Cart { get; set; }
            public bool OrderStatus { get; set; }
            public DateTime Date { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowUnhandled();
            ShowHandled();
        }

        private void ShowUnhandled()
        {
            List<RamenQueue> unhandledTransactions = (List<RamenQueue>)Application["UnhandledTransactions"];
            if (unhandledTransactions != null)
            {
                List<RamenQueue> unhandledFalseTransactions = unhandledTransactions.Where(t => t.OrderStatus == false).ToList();
                OrderList.DataSource = unhandledFalseTransactions.Select(x =>
                {
                    return new
                    {
                        x.CustomerName,
                        x.OrderStatus,
                        x.Date
                    };
                });
                OrderList.DataBind();
            }
        }

        private void ShowHandled()
        {
            List<Header> headers = TransactionHeaderRepository.GetHeaders();
            HandledList.DataSource = headers;
            HandledList.DataBind();

        }

        protected void OrderList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                List<RamenQueue> unhandledTransactions = (List<RamenQueue>)Application["UnhandledTransactions"];

                if (unhandledTransactions != null && index >= 0 && index < unhandledTransactions.Count)
                {
                    string customerName = unhandledTransactions[index].CustomerName;
                    int member = UserRepository.GetUserID(customerName);
                    int staff = UserRepository.GetUserID((String)Session["User"]);
                    var id = AllHandler.HeaderInsert(member, staff, DateTime.Now);

                    unhandledTransactions[index].OrderStatus = true;

                    foreach(Cart cart in unhandledTransactions[index].Cart)
                    {
                        AllHandler.DetailInsert(id, cart.Ramen.ID, cart.Quantity);
                    }
                    unhandledTransactions.RemoveAt(index);
                }

            }
            ShowUnhandled();
            ShowHandled();
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
    }
}