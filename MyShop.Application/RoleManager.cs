using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyShop.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application
{
    public class RoleManager:Microsoft.AspNet.Identity.RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>, IRoleManager
    {
        public RoleManager(IDbContext context):base(new Microsoft.AspNet.Identity.EntityFramework.RoleStore<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>((DbContext)context))
        {

        }

        public Task<IdentityResult> CDeleteAsync(IdentityRole role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RoleExistAsync(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
