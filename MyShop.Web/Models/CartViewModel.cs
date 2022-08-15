using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    /// <summary>
    /// ViewModel para el carrito
    /// </summary>
    public class CartViewModel
    {
        /// <summary>
        /// Identificador del carrito
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Cantidad
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Precio
        /// </summary>
        public decimal Price { get; set; }
    }
}