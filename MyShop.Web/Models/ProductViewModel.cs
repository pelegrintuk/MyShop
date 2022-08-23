using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    /// <summary>
    /// ViewModel para el listado de productos
    /// </summary>
    public class ProductViewModel
    {
        /// <summary>
        /// Identificador del producto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ruta a la imagen del producto
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Precio del producto
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Cantidad
        /// </summary>
        public int Quantity { get; set; }
    }
}