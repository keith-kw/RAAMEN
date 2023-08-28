using FinalProject1.Factory;
using FinalProject1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Repository
{
    public class TransactionHeaderRepository
    {
        public static LocalDatabaseEntities1 db = new LocalDatabaseEntities1(); 
        public static int AddHeader(int member, int staff, DateTime date)
        {
            Header h = TransactionHeaderFactory.CreateHeader(member, staff, date);
            db.Headers.Add(h);
            db.SaveChanges();
            return h.ID;
        }

        public static List<Header> GetHeaders()
        {
            return db.Headers.ToList();
        }

        public static List<Header> GetHeadersByID(int id)
        {
            return db.Headers.Where(x => x.CustomerID == id).ToList();
        }
    
        public static Header GetHeader(int id)
        {
            return db.Headers.FirstOrDefault(x => x.ID == id);
        }

    }
}