using FinalProject1.Factory;
using FinalProject1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Repository
{
    public class RamenRepository
    {
        public static LocalDatabaseEntities1 db = new LocalDatabaseEntities1();

        public static void RegisterRamen(string name, string meat, string broth, string price)
        {
            Ramen ramen = RamenFactory.CreateRamen(name, meat, broth, price);
            db.Ramen1.Add(ramen);
            db.SaveChanges();
        }


        public static Ramen GetRamenByName(string name)
        {
            return db.Ramen1.FirstOrDefault(x => x.Name.Equals(name));
        }

        public static string GetRamenByID(int id)
        {
            Ramen ramen = db.Ramen1.FirstOrDefault(x => x.ID == id);
            if(ramen != null)
            {
                return ramen.Name;
            }
            else
            {
                return "";
            }
        }


        public static int GetMeatByName(string meat)
        {
            Meat meats = db.Meats.FirstOrDefault(x => x.Name.Equals(meat));

            if (meats != null)
            {

                return meats.ID;

            }
            else
            {

                return 0;

            }
        }

        public static string GetMeatByID(int id)
        {
            Meat meats = db.Meats.FirstOrDefault(x => x.ID == id);

            if (meats != null)
            {

                return meats.Name;

            }
            else
            {

                return "";

            }
        }

        public static void UpdateRamen(string name, string meat, string broth, string price)
        {
            Ramen ramen = GetRamenByName(name);
            if (ramen != null)
            {
                ramen.Name = name;
                ramen.MeatID = GetMeatByName(meat);
                ramen.Broth = broth;
                ramen.Price = price;
                db.SaveChanges();
            }
        }

        public static List<Object> GetRamens()
        {
            return db.Ramen1.Select(x => new {
                x.ID,
                x.Name,
                x.Broth,
                x.Price,
                MeatName = x.Meat.Name
            }).ToList<Object>();
        }

        public static List<Ramen> GetRamenList()
        {
            return db.Ramen1.ToList();
        }

        public static void DeleteRamen(string name)
        {
            Ramen ramen = db.Ramen1.FirstOrDefault(x => x.Name.Equals(name));
            if (ramen == null)
            {
                return;
            }
            db.Ramen1.Remove(ramen);
            db.SaveChanges();
        }
    }
}