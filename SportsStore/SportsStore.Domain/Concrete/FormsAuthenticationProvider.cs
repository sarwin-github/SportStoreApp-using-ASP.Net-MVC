﻿using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class FormsAuthenticationProvider : IAuthentication
    {
        private readonly EFDbContext context = new EFDbContext();

        public bool Authenticate(string username, string password)
        {
            var result = context
                        .Users
                        .Where(u => u.UserId == username && u.Password == password)
                        .FirstOrDefault();
            if(result == null)
                return false;
            return true;
        }


        public bool Logout()
        {
            return true;
        }
    }
}
