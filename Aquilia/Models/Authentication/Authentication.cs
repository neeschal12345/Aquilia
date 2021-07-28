using System;
using Microsoft.AspNetCore.Identity;

namespace Aquilia.Models.Authentication
{
    public class Authentication : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNo { get; set; }
    }
}
