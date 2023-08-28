using FinalProject1.Handler;
using FinalProject1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FinalProject1.Controller
{
    public class UserController
    {
        public static string RegisterCheck(string username, string email, string gender, string password, string confirm)
        {
            if (String.IsNullOrEmpty(username))
            {
                return "Username must be filled!";
            }
            if (username.Length < 5 || username.Length > 15)
            {
                return "Username must between 5 and 15 characters!";
            }
            if (!Regex.IsMatch(username, @"^[a-zA-Z\s]+$"))
            {
                return "Username must only contain alphabet and space!";
            }
            if (String.IsNullOrEmpty(email))
            {
                return "Email must be filled!";
            }
            if (!email.EndsWith(".com"))
            {
                return "Email must end with .com!";
            }
            if (String.IsNullOrEmpty(gender))
            {
                return "Gender must be chosen!";
            }
            if (String.IsNullOrEmpty(password))
            {
                return "Password must be filled!";
            }
            if (String.IsNullOrEmpty(confirm))
            {
                return "Password Confirmation must be filled!";
            }
            if (!password.Equals(confirm))
            {
                return "Password must match with Confirmation password!";
            }
            if (!confirm.Equals(password))
            {
                return "Confirmation Password must match with Password!";
            }
            else
            {
                int id = UserRepository.GetRole(username);
                bool check = AllHandler.UserRegister(username, id, email, gender, password);
                return "You've been registered!";
            }
        }

        public static string UpdateCheck(string username, string email, string gender, string password)
        {
            if (String.IsNullOrEmpty(username))
            {
                return "Username must be filled!";
            }
            if (username.Length < 5 || username.Length > 15)
            {
                return "Username must between 5 and 15 characters!";
            }
            if (!Regex.IsMatch(username, @"^[a-zA-Z\s]+$"))
            {
                return "Username must only contain alphabet and space!";
            }
            if (String.IsNullOrEmpty(email))
            {
                return "Email must be filled!";
            }
            if (!email.EndsWith(".com"))
            {
                return "Email must end with .com!";
            }
            if (String.IsNullOrEmpty(gender))
            {
                return "Gender must be chosen!";
            }
            if (String.IsNullOrEmpty(password))
            {
                return "Password must be filled!";
            }
            else
            {
                bool check = AllHandler.UserUpdate(username, email, gender, password);
                if (check == true)
                {
                    return "Profile Updated";
                }
                else
                {
                    return "Wrong Credentials";
                }
            }
        }

        public static int CheckRole(string username)
        {

            return UserRepository.GetRole(username);

        }
    }
}