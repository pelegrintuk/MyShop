using MyShop.CORE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Interfaces
{
    /// <summary>
    /// Manager del carrito de la compra
    /// </summary>
    public interface IShoppingCartManager :IManager<ShoppingCart>
    {
        /// <summary>
        /// Añade producto al carrito de la compra
        /// </summary>
        /// <param name="userId">Identificador del usuario</param>
        /// <param name="sessionId">Identificador de la sesión</param>
        /// <param name="productId">Identificador del producto</param>
        /// <param name="quantity">Cantidad a añadir</param>
        /// <returns>Elementos en el carrito</returns>
        int AddProduct(string userId, string sessionId, int productId, int quantity);
        /// <summary>
        /// Obtiene el carrito de un usuario
        /// </summary>
        /// <param name="userId">Identificador de usuario</param>
        /// <param name="sessionId">identificador de la sesión</param>
        /// <returns></returns>
        IQueryable<ShoppingCart> GetShoppingCartByUser(string userId, string sessionId);
    }
}
