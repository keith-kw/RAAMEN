using FinalProject1.Model;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Factory
{
    public class RamenFactory
    {
        public static Ramen CreateRamen(string name, string meat, string broth, string price)
        {
            var m = RamenRepository.GetMeatByName(meat);
            return new Ramen()
            {
                Name = name,
                MeatID = m,
                Broth = broth,
                Price = price
            };
        }
    }
}