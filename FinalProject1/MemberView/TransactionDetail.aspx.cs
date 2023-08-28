using FinalProject1.Controller;
using FinalProject1.Model;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static FinalProject1.MemberView.OrderRamen;
using static FinalProject1.StaffView.OrderQueue;

namespace FinalProject1.MemberView
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["headerId"] != null)
                {
                int HeaderId = Convert.ToInt32(Request.QueryString["headerId"]);

                TransactionDetails(HeaderId);
            }
            else
            {
                Response.Redirect("History.aspx");
            }
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

        private void TransactionDetails(int id)
        {
            Header header = TransactionHeaderRepository.GetHeader(id);
            string customerName = UserRepository.GetUserByID(header.CustomerID);

            memberLbl.Text = customerName;

            List<Detail> details = TransactionDetailRepository.GetDetails(id);
            HistoryDetail.DataSource = details.Select(x =>
            {
                return new
                {
                    RamenName = RamenRepository.GetRamenByID(x.RamenID),
                    x.Quantity
                };
            });
            HistoryDetail.DataBind();
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("History.aspx");
        }
    }
}