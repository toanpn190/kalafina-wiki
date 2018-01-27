using Kalafina.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kalafina.Models
{
    public class ApplicationUserContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationUserContext()
            : base("KalafinaUserContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationUserContext Create()
        {
            return new ApplicationUserContext();
        }
    }
}