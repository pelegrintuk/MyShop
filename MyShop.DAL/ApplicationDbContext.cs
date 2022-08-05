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
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>,IDbContext
    {
        /// <summary>
        /// Constructor para migraciones
        /// </summary>
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
        /// <summary>
        /// Constructor con cadena de conexión
        /// </summary>
        /// <param name="nameOrConnectionString">Cadena de conexión</param>
        public ApplicationDbContext(string nameOrConnectionString)
            :base(nameOrConnectionString, false)
        {

        }
        #region Colecciones
        /// <summary>
        /// Colección de pedidos
        /// </summary>
        public DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Colección de productos
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Colección de carritos
        /// </summary>
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        #endregion
        /// <summary>
        /// Elimina el borrado en cascada entre order y dirección de envio.
        /// </summary>
        /// <param name="modelBuilder">Modelo de BBDD</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasRequired(f => f.DeliveryAddress).WithMany().WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// Metodo para creación del contexto de datos
        /// </summary>
        /// <returns>Contexto</returns>
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
