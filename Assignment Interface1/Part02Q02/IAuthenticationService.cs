using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface1.Part02Q02
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string UserName, string Password);

        bool AuthrizeUser(string UserName, string role);
    }
}
