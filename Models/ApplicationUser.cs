﻿using Microsoft.AspNetCore.Identity;

namespace IMSIdentity.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName {  get; set; }
        public string UserType {  get; set; }   
    }
}
