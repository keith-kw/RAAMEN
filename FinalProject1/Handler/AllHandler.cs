using FinalProject1.Model;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Handler
{
    public class AllHandler
    {
        public static bool RamenInsertHandler(string name, string meat, string broth, string price)
        {
            Ramen ramen = RamenRepository.GetRamenByName(name);
            if (ramen != null)
            {
                return false;
            }
            else
            {
                RamenRepository.RegisterRamen(name, meat, broth, price);
                return true;
            }
        }

        public static bool RamenDeleteHandler(string name)
        {
            Ramen ramen = RamenRepository.GetRamenByName(name);
            if (ramen == null)
            {
                return false;
            }
            else
            {
                RamenRepository.DeleteRamen(name);
                return true;
            }
        }

        public static bool RamenUpdateHandler(string name, string meat, string broth, string price)
        {
            Ramen ramen = RamenRepository.GetRamenByName(name);
            if (ramen == null)
            {
                return false;
            }
            else
            {
                RamenRepository.UpdateRamen(name, meat, broth, price);
                return true;
            }
        }

        public static bool UserRegister(string username, int id, string email, string gender, string password)
        {
            User user = UserRepository.GetUsername(username);
            if (user == null)
            {
                UserRepository.RegisterUser(username, id, email, gender, password);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool UserUpdate(string username, string email, string gender, string password)
        {
            User user = UserRepository.GetUsername(username);
            if (user == null)
            {
                return false;
            }
            else
            {
                UserRepository.UpdateProfile(username, email, gender, password);
                return true;
            }
        }

        public static int HeaderInsert(int member, int staff, DateTime date)
        {
            return TransactionHeaderRepository.AddHeader(member, staff, date);
        }

        public static void DetailInsert(int id, int ramen, int qty)
        {
            TransactionDetailRepository.AddDetail(id, ramen, qty);
        }
    }
}