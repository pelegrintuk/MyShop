using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Domain
{
    /// <summary>
    /// Clase de dirección.
    /// </summary>
    class Address
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Texto para primera linea de dirección
        /// </summary>
        public string AddressText1 { get; set; }
        /// <summary>
        /// Texto para segunda linea de dirección
        /// </summary>
        public string AddressText2 { get; set; }
        /// <summary>
        /// Código postal
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// Ciudad
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Provincia
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// Pais
        /// </summary>
        public string Country { get; set; }
        #region Propiedades de usuario
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
    }
}
