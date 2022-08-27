using MyShop.CORE.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    public class OrderViewModel
    {
        /// <summary>
        /// Identificador
        /// </summary>
        [Display(Name = "ID")]
        public int Id { get; set; }
        public int StatusId { get; set; }
        /// <summary>
        /// Estado
        /// </summary>
        [Display(Name ="Estado")]
        public string Status { get{ return Enum.GetName(typeof(OrderStatus), StatusId);} }
        /// <summary>
        /// Fecha de creación
        /// </summary>
        [Display(Name = "Fecha de creación")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Fecha de pago
        /// </summary>
        [Display(Name = "Fecha de envío")]
        public DateTime? SendDate { get; set; }
        /// <summary>
        /// Fecha de recepción
        /// </summary>
        [Display(Name = "Fecha de entrega")]
        public DateTime? DeliveryDate { get; set; }
        /// <summary>
        /// Fecha de cancelación
        /// </summary>
        [Display(Name = "Fecha de cancelación")]
        public DateTime? CancellationDate { get; set; }
        /// <summary>
        /// Nombre de usuario
        /// </summary>
        [Display(Name = "Usuario")]
        public string User{ get; set; }
        /// <summary>
        /// Id de la linea de pedido
        /// </summary>
        public int OrderLineId { get; set; }
        /// <summary>
        /// Precio del total
        /// </summary>
        [Display(Name = "Precio total")]
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// Numero de tarjeta de credito para el pago
        /// </summary>
        [Display(Name = "Numero de tarjeta usado para el pago")]
        public string CardNumber { get; set; }
    }
}