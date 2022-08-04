using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Domain
{
    /// <summary>
    /// Clase de productos
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Descripcion del producto
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Precio del producto
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Stock del producto
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// Boleano que indica si el producto esta disponible
        /// </summary>
        public bool Avaliable { get; set; }
    }
}
