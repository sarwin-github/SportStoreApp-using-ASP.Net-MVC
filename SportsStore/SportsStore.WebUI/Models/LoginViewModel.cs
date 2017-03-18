﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsStore.WebUI.Models
{
    public class LoginViewModel
    {   
        [Required(ErrorMessage = "User name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(maximumLength:50, MinimumLength = 8)]
        public string Password { get; set; }
    }
}