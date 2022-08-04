using Microsoft.AspNet.Identity.EntityFramework;
using MyShop.CORE;
using MyShop.CORE.Domain;
using MyShop.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DAL
{
    /// <summary>
    /// Contexto de datos
    /// </summary>
    /// TODO Falta comentar todo.
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>,IDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
        public ApplicationDbContext(string nameOrConnectionString)
            :base(nameOrConnectionString, false)
        {

        }
        #region Colecciones
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        #endregion
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasRequired(f => f.DeliveryAddress).WithMany().WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
