using MyShop.CORE.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Domain
{
    /// <summary>
    /// Clase de pedidos
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Estado
        /// </summary>
        public OrderStatus Status { get; set; }
        #region Fechas del pedido
        /// <summary>
        /// Fecha de creación
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Fecha de pago
        /// </summary>
        public DateTime? SendDate { get; set; }
        /// <summary>
        /// Fecha de recepción
        /// </summary>
        public DateTime? DeliveryDate { get; set; }
        /// <summary>
        /// Fecha de cancelación
        /// </summary>
        public DateTime? CancellationDate { get; set; }
        #endregion
        #region Relaciones con el usuario
        /// <summary>
        /// Identificador del usuario
        /// </summary>
        [ForeignKey("User")]
        public string UserId { get; set; }
        /// <summary>
        /// Objeto del usuario
        /// </summary>
        public ApplicationUser User { get; set; }
        #endregion
        /// <summary>
        /// Id de la linea de pedido
        /// </summary>
        [ForeignKey("OrderLine")]
        public int OrderLineId { get; set; }
        /// <summary>
        /// Lineas de pedido
        /// </summary>
        public List<OrderLine> OrderLine { get; set; }
        /// <summary>
        /// Precio del total
        /// </summary>
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// Numero de tarjeta de credito para el pago
        /// </summary>
        public string CardNumber { get; set; }
    }
}
