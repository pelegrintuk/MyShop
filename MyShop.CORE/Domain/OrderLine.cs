using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Domain
{
    class OrderLine
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        #region Datos del producto        

        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Precio neto del producto
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// Nombre del impuesto aplicado
        /// </summary>
        public decimal TotalPrice { get; set; }

        #endregion

        /// <summary>
        /// Cantidad de producto
        /// </summary>
        public decimal Quantity { get; set; }

    }
}
