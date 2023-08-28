using FinalProject1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Factory
{
    public class TransactionDetailFactory
    {
        public static Detail CreateDetail(int id, int ramen, int qty)
        {
            return new Detail()
            {
                HeaderID = id,
                RamenID = ramen,
                Quantity = qty
            };
        }
    }
}