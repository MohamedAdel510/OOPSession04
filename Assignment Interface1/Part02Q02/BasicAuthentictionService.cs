using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface1.Part02Q02
{
    internal class BasicAuthentictionService : IAuthenticationService
    {
        private readonly static string userName = "MohamedAdel";
        private readonly static string password = "Mohamed123";
        private readonly static string role = "Admin";

        public static string UserName
        {
            get { return userName; }
        }
        public static string Password
        { get { return password; } }
        public static string Role
        { get { return role; } }

        public bool AuthenticateUser(string _UserName, string _Password)
        {
            if (_UserName == UserName && _Password == Password) 
                return true;
            return false;
        }

        public bool AuthrizeUser(string _UserName, string _Role)
        {
            if(_UserName == UserName && _Role == Role)
                return true;
            return false;
        }
    }
}
