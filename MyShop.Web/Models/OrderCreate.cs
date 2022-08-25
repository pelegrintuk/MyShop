using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [Display(Name = "Numero de tarjeta")]
        public string CardNumber { get; set; }
        /// <summary>
        /// Mes de caducidad de la tarjeta de credito
        /// </summary>
        [Required]
        [Display(Name = "Mes de caducidad")]
        public int Mes { get; set; }
        /// <summary>
        /// Año de caducidad de la tarjeta de credito
        /// </summary>
        [Required]
        [Display(Name = "Año de caducidad")]
        public int Año { get; set; }
    }
}