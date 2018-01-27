using Microsoft.Owin;
using Kalafina.Models;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

[assembly: OwinStartup(typeof(Kalafina.Startup))]
namespace Kalafina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createDefaultRolesAndUsers();
        }

        private void createDefaultRolesAndUsers()
        {
            ApplicationUserContext context = new ApplicationUserContext();

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var RoleManager = new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole>(context));

            if (!RoleManager.RoleExists("Admin"))
            {
                // create Admin role
                var role = new ApplicationRole() { Name = "Admin" };
                RoleManager.Create(role);

                // create default user and make him the Admin
                var user = new ApplicationUser() { UserName = "crowee190@gmail.com", Email = "crowee190@gmail.com" };

                var chkUser = UserManager.Create(user, "1234Share");
                
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                }
            }

            if (!RoleManager.RoleExists("User"))
            {
                var role = new ApplicationRole();
                role.Name = "User";
                RoleManager.Create(role);
            }
        }
    }
}
