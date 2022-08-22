using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    public class ProductCreate
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
        /// Descripción del producto
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Precio
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Productos disponibles
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// Disponibilidad
        /// </summary>
        public bool Avaliable { get; set; }
        /// <summary>
        /// Imagen
        /// </summary>
        public string Image { get; set; }
    }
}
