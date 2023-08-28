using FinalProject1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Factory
{
    public class TransactionHeaderFactory
    {
        public static Header CreateHeader(int member, int staff, DateTime date)
        {
            return new Header()
            {
                CustomerID = member,
                StaffID = staff,
                Date = date
            };
        }
    }
}