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
        /// Colección de productos
        /// </summary>
        public IEnumerable<ProductList> Products { get; set; }
        /// <summary>
        /// Numero de productos a mostrar
        /// </summary>
        public int ProductCount { get; set; }
    }
}