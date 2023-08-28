using FinalProject1.Factory;
using FinalProject1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Repository
{
    public class UserRepository
    {
        public static LocalDatabaseEntities1 db = new LocalDatabaseEntities1();

        public static bool CheckUser(string username, string password)
        {
            User user = db.Users.FirstOrDefault(x => x.Username.Equals(username) && x.Password.Equals(password));
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void RegisterUser(string username, int id, string email, string gender, string password)
        {
            User user = UserFactory.CreateUser(username, id, email, gender, password);
            db.Users.Add(user);
            db.SaveChanges();

        }

        public static void UpdateProfile(string username, string email, string gender, string password)
        {
            User user = db.Users.FirstOrDefault(x => x.Password.Equals(password));
            if (user == null)
            {
                return;
            }
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            db.SaveChanges();
        }

        public static User GetUsername(string username)
        {
            return db.Users.FirstOrDefault(x => x.Username == username);
        }

        public static int GetUserID(string username)
        {
            User user = db.Users.FirstOrDefault(x => x.Username.Equals(username));

            if(user != null)
            {
                return user.ID;
            }
            else
            {
                return 0;
            }
        }

        public static int GetRole(string username)
        {
            if (username.Contains("Admin"))
            {
                return 1;
            }
            else if (username.Contains("Staff"))
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public static List<User> GetCustomer()
        {
            return db.Users.Where(x => x.RoleID == 3).ToList();
        }

        public static List<User> GetStaff()
        {
            return db.Users.Where(x => x.RoleID == 2).ToList();
        }

        public static string GetUserByID(int id)
        {
            User user = db.Users.FirstOrDefault(x => x.ID == id);
            if(user != null)
            {
                return user.Username;
            }
            else
            {
                return "";
            }
        }
    }
}