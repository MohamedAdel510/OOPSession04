﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.OperatorOverloading
{
    internal class UserViewModel
    {
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }


        public static explicit operator UserViewModel(User user)
        {
            string[]? names = user?.Name?.Split(" ");
            return new UserViewModel()
            {
                FName = names?.Length > 0 ? names[0] : string.Empty,
                LName = names?.Length > 0 ? names[1] : string.Empty,
                Email = user?.Email ?? string.Empty,
                Password = user?.Password ?? string.Empty                 
            };
        }
    }
}
