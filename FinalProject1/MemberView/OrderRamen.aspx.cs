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
    public partial class OrderRamen : System.Web.UI.Page
    {
        public class Cart
        {

            public Ramen Ramen { get; set; }

            public int Quantity { get; set; }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            OrderMenu();
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

        protected void OrderMenu()
        {
            List<Object> ramens = RamenRepository.GetRamens();
            OrderRamenMenu.DataSource = ramens;
            OrderRamenMenu.DataBind();
        }

        protected void OrderRamenMenu_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                List<Ramen> ramens = RamenRepository.GetRamenList();

                if (index >= 0 && index < ramens.Count)
                {
                    Ramen selectedRamen = ramens[index];

                    List<Cart> ramenCart = (List<Cart>)Session["RamenCart"];

                    if (ramenCart == null)
                    {
                        ramenCart = new List<Cart>();
                        Session["RamenCart"] = ramenCart;
                    }

                    Cart cart = ramenCart.FirstOrDefault(c => c.Ramen.ID == selectedRamen.ID);
                    if (cart != null)
                    {
                        cart.Quantity += 1;
                    }
                    else
                    {
                        ramenCart.Add(new Cart
                        {
                            Ramen = selectedRamen,
                            Quantity = 1
                        });
                    }
                }
                CartGrid();
            }
        }

        private void CartGrid()
        {
            List<Cart> ramenCart = (List<Cart>)Session["RamenCart"];

            if (ramenCart != null)
            {
                OrderCart.DataSource = ramenCart.Select(x =>
                {
                    return new
                    {
                        RamenName = x.Ramen.Name,
                        MeatName = RamenRepository.GetMeatByID(x.Ramen.MeatID),
                        x.Ramen.Price,
                        x.Ramen.Broth,
                        x.Quantity
                    };
                });
                OrderCart.DataBind();
            }
        }

        protected void OrderCart_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                List<Cart> ramenCart = (List<Cart>)Session["RamenCart"];

                if (index >= 0 && index < ramenCart.Count)
                {
                    if (ramenCart[index].Quantity > 1)
                    {
                        ramenCart[index].Quantity -= 1;
                    }
                    else
                    {
                        ramenCart.RemoveAt(index);
                    }
                }
                CartGrid();
            }
        }

        protected void BuyBtn_Click(object sender, EventArgs e)
        {
            
            List<Cart> ramenCart = (List<Cart>)Session["RamenCart"];

            if (ramenCart != null && ramenCart.Count > 0)
            {
                RamenQueue queueOrder = new RamenQueue();

                queueOrder.Cart = ramenCart.ToList();
                queueOrder.OrderStatus = false;
                queueOrder.CustomerName = (string)Session["User"];
                List<RamenQueue> unhandledTransactions = (List<RamenQueue>)Application["UnhandledTransactions"];

                if (unhandledTransactions == null)
                {
                    unhandledTransactions = new List<RamenQueue>();
                    Application["UnhandledTransactions"] = unhandledTransactions;
                }

                unhandledTransactions.Add(queueOrder);
                ramenCart.Clear();
                CartGrid();
            }
        }

        protected void ClearAllBtn_Click(object sender, EventArgs e)
        {
            List<Cart> ramenCart = (List<Cart>)Session["RamenCart"];

            if (ramenCart != null)
            {
                ramenCart.Clear();
                CartGrid();
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