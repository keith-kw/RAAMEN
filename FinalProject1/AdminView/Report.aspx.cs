using CrystalDecisions.CrystalReports.Engine;
using FinalProject1.Model;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject1.AdminView
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dataSet = new DataSet();

            List<Ramen> ramens = RamenRepository.GetRamenList();
            List<Header> headers = TransactionHeaderRepository.GetHeaders();

            foreach(Ramen ramen in ramens)
            {
                var ramenRow = dataSet.Ramen.NewRow();
                ramenRow["ID"] = ramen.ID;
                ramenRow["MeatID"] = ramen.MeatID;
                ramenRow["Name"] = ramen.Name;
                ramenRow["Broth"] = ramen.Broth;
                ramenRow["Price"] = ramen.Price;

                dataSet.Ramen.Rows.Add(ramenRow);

            }

            foreach(Header header in headers)
            {
                var headerRow = dataSet.Header.NewRow();
                headerRow["ID"] = header.ID;
                headerRow["CustomerID"] = header.CustomerID;
                headerRow["StaffID"] = header.StaffID;
                headerRow["Date"] = header.Date;

                dataSet.Header.Rows.Add(headerRow);

                foreach(Detail d in header.Details)
                {
                    var detailRow = dataSet.Detail.NewRow();
                    detailRow["HeaderID"] = d.HeaderID;
                    detailRow["RamenID"] = d.RamenID;
                    detailRow["Quantity"] = d.Quantity;

                    dataSet.Detail.Rows.Add(detailRow);
                }

            }

            var crystalReport = new CrystalReport();
            crystalReport.SetDataSource(dataSet);

            int sum = 0;
            foreach(Header h in headers)
            {
                foreach(Detail d in h.Details)
                {
                    int qty = Convert.ToInt32(d.Quantity);
                    int price = Convert.ToInt32(d.Raman.Price);
                    sum +=  qty * price;
                }
            }
            var total = crystalReport.Subreports.Count;
            var grandTotal = (TextObject)crystalReport.ReportDefinition.ReportObjects["Total"];
            grandTotal.Text = $"Grand Total: {sum}";

            ReportViewer.ReportSource = crystalReport;
            ReportViewer.DataBind();
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }
    }
}