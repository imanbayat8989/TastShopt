﻿using Microsoft.AspNetCore.Identity;

namespace TastShopt.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
    }
}
