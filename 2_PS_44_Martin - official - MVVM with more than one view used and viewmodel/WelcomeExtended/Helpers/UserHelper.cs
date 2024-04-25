using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    internal static class UserHelper
    {
        public static string toString(this User user)
        {
            string facNumString = string.Empty;
            if(user.FacNum == "" || user.FacNum == null) { facNumString = "no"; }
            else { facNumString = user.FacNum; }
            return $"Name: {user.Name}, Role: {user.Role}, facultity number: {facNumString}, Email: {user.Email}";
        }

        // call by this userData, extension method
        public static bool ValidateCredentials(this UserData userData, string name, string password, out string errorMessage)
        {
            if (name == null || name == "") {
                errorMessage = "The name field cannot be empty";
                return false;
            }
            if(password == null || password == "")
            {
                errorMessage = "The password field cannot be empty";
                return false;
            }

            

            if (userData.ValidateUser(name, password))
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "The user is not found!";
            return false;
        }

        public static User GetUser(this UserData userData, string name, string password)
        {
            return userData.getUser(name, password);
        }
    }
}
