using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string name { get; set; }
        /// <summary>
        /// Apellidos del usuario
        /// </summary>
        [Required]
        public string Surname { get; set; }
        /// <summary>
        /// Dirección del usuario
        /// </summary>
        private Address Address { get; set; }
    }
}
