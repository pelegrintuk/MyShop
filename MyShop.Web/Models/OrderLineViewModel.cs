using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    /// <summary>
    /// View model para las lineas de pedido
    /// </summary>
    public class OrderLineViewModel
    {
        /// <summary>
        /// Identificador
        /// </summary>
        [Display(Name = "ID")]
        public int Id { get; set; }

        #region Datos del producto        

        /// <summary>
        /// Nombre del producto
        /// </summary>
        [Display(Name = "Nombre del producto")]
        public string ProductName { get; set; }

        /// <summary>
        /// Precio neto del producto
        /// </summary>
        [Display(Name = "Precio")]
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// Cantidad de producto
        /// </summary>
        [Display(Name = "Cantidad")]
        public decimal Quantity { get; set; }
        #endregion
    }
}