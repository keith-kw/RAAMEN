using FinalProject1.Factory;
using FinalProject1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Repository
{
    public class TransactionDetailRepository
    {
        public static LocalDatabaseEntities1 db = new LocalDatabaseEntities1();

        public static void AddDetail(int id, int ramen, int qty)
        {
            Detail d = TransactionDetailFactory.CreateDetail(id, ramen, qty);
            db.Details.Add(d);
            db.SaveChanges();
        }

        public static List<Detail> GetDetails(int id)
        {
            return db.Details.Where(x => x.HeaderID == id).ToList();
        }
    }
}