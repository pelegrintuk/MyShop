using Microsoft.AspNet.Identity.EntityFramework;
using MyShop.CORE.Domain;
using MyShop.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application
{
    /// <summary>
    /// Manager de usuario
    /// </summary>
    public class MyUserManager : Microsoft.AspNet.Identity.UserManager<ApplicationUser>, IUserManager
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public MyUserManager(IDbContext context):base(new UserStore<ApplicationUser>((DbContext)context))
        {

        }
        /// <inheritdoc/>
        public bool UserLockoutEnableByDefault { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        /// <inheritdoc/>
        public TimeSpan DefaultLockoutTimeSpan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
