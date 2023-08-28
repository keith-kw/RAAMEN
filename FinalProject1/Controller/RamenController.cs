using FinalProject1.Handler;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Controller
{
    public class RamenController
    {
        public static string CheckInsertRamen(string name, string meat, string broth, string price)
        {

            if (string.IsNullOrEmpty(name))
            {
                return "Ramen name must be filled!";
            }
            if (!name.Contains("Ramen"))
            {
                return "Name must contain Ramen!";
            }
            if (string.IsNullOrEmpty(meat))
            {
                return "Ramen Meat must be selected!";
            }
            if (string.IsNullOrEmpty(broth))
            {
                return "Broth name must be filled!";
            }
            if (string.IsNullOrEmpty(price))
            {
                return "Ramen price must be filled!";
            }
            var p = Int32.Parse(price);
            if (p < 3000)
            {
                return "Price must be at least 3000!";
            }
            var flag = RamenRepository.GetRamenByName(name);
            if (flag != null)
            {
                return "Ramen name must be unique";
            }

            else
            {
                bool check = AllHandler.RamenInsertHandler(name, meat, broth, price);
                if (check)
                {
                    return "Ramen has been inserted!";
                }
                else
                {
                    return "Wrong Credentials";
                }
            }
        }

        public static string CheckUpdateRamen(string name, string meat, string broth, string price)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Ramen name must be filled!";
            }
            if (!name.Contains("Ramen"))
            {
                return "Name must contain Ramen!";
            }
            if (string.IsNullOrEmpty(meat))
            {
                return "Ramen Meat must be selected!";
            }
            if (string.IsNullOrEmpty(broth))
            {
                return "Broth name must be filled!";
            }
            if (string.IsNullOrEmpty(price))
            {
                return "Ramen price must be filled!";
            }

            var p = Int32.Parse(price);
            if (p < 3000)
            {
                return "Price must be at least 3000!";
            }
            else
            {
                bool check = AllHandler.RamenUpdateHandler(name, meat, broth, price);
                if (check)
                {
                    return "Ramen has been updated!";
                }
                else
                {
                    return "Wrong Credentials";
                }
            }
        }

        public static string CheckDeleteRamen(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Ramen name must be filled!";
            }
            else
            {
                bool check = AllHandler.RamenDeleteHandler(name);
                if (check)
                {
                    return "Ramen has been deleted!";
                }
                else
                {
                    return "Wrong Credentials";
                }
            }
        }
    }
}