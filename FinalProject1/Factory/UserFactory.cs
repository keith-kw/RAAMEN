using FinalProject1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject1.Factory
{
    public class UserFactory
    {
        public static User CreateUser(string username, int id, string email, string gender, string password)
        {
            return new User()
            {
                Username = username,
                RoleID = id,
                Email = email,
                Gender = gender,
                Password = password
            };
        }
    }
}