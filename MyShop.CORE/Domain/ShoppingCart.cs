﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Domain
{
    /// <summary>
    /// Clase para el carrito de la compra
    /// </summary>
    class ShoppingCart
    {
        /// <summary>
        /// identificador del carrito
        /// </summary>
        public int Id { get; set; }
        #region Relación con el usuario
        /// <summary>
        /// Identificador del usuario que creo el carrito
        /// </summary>
        [ForeignKey("User")]
        public int UserId { get; set; }
        /// <summary>
        /// Objeto del usuario
        /// </summary>
        public ApplicationUser User { get; set; }
        #endregion
        #region Relación con el producto
        /// <summary>
        /// Identificador del producto añadido al carrito
        /// </summary>
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        /// <summary>
        /// Objeto del producto añadido
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// Cantidad del producto añadido
        /// </summary>
        public int Quantity { get; set; }
        #endregion
        /// <summary>
        /// Sesion del usuario
        /// </summary>
        public string Sesion { get; set; }
        /// <summary>
        /// Fecha de creación del carrito
        /// </summary>
        public DateTime Date { get; set; }
    }
}
