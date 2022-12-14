using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Domain
{
    /// <summary>
    /// Clase de usuario
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
        /// <summary>
        /// NIF del usuario
        /// </summary>
        [MaxLength(10)]
        [Required]
        [MinLength(7)]
        public string NIF { get; set; }
        /// <summary>
        /// Nombre del usuario
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Apellidos del usuario
        /// </summary>
        [Required]
        public string Surname { get; set; }
        // [ForeignKey ("Address")]
        // public int AddressId { get; set; }
        /// <summary>
        /// Dirección del usuario
        /// </summary>
        #region Dirección
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
        #endregion
    }
}
