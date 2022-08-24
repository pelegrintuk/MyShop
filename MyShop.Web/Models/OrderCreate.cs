using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    public class OrderCreate
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Numero de tarjeta de credito para el pago
        /// </summary>
        public string CardNumber { get; set; }
    }
}