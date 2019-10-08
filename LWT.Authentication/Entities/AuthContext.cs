using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LWT.Authentication.Entities
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext () : base("Server=DESKTOP-TT2CO68\\SQLEXPRESS;Database=ContactBookApplication;Trusted_Connection=true") { }
    }
}
