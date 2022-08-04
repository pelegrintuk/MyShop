using MyShop.CORE.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Interfaces
{
    /// <summary>
    /// Interfaz del contexto de datos
    /// </summary>
    public interface IDbContext
    {
        /// <summary>
        /// Colección de pedidos
        /// </summary>
        DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Colección de productos
        /// </summary>
        DbSet<Product> Products { get; set; }
        /// <summary>
        /// Colección de carritos
        /// </summary>
        DbSet<ShoppingCart> ShoppingCart { get; set; }
        /// <summary>
        /// Metodo para el guardado
        /// </summary>
        /// <returns>Registros afectados</returns>
        int SaveChanges();
        /// <summary>
        /// Devuelve la colección de una entidad
        /// </summary>
        /// <typeparam name="T">Entidad de la que queremos el contexto</typeparam>
        /// <returns>Colección de la entidad</returns>
        DbSet<T> Set<T>() where T : class;
        /// <summary>
        /// Devuelve la entrada de una entidad del contexto
        /// </summary>
        /// <typeparam name="T">Tipo de entidad de la que queremos la entrada</typeparam>
        /// <param name="entity">Entidad de la que queremos su entrada</param>
        /// <returns>Entrada de la entidad</returns>
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
