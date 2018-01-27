using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kalafina.Models
{
    public class ApplicationRole : IdentityRole
    {
        // Not sure if this is needed or not, and if yes then why?
        // 
        // Answer: To inherit the "Creating new instance of the class" property from base (aka IdentityRole)
        // (not 100% sure so just put it like that)
        // if do not use this then can still use  var role = new ApplicationRole; role.Name = "Admin";
        // or even  var role = new ApplicationRole() { Name = "Admin" };

        /*
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }
        */
    }
}