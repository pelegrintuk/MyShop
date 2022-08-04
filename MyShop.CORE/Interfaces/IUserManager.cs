using Microsoft.AspNet.Identity;
using MyShop.CORE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Interfaces
{
    /// <summary>
    /// Interfaz del manager de usuario
    /// </summary>
    public interface IUserManager :IDisposable
    {
        /// <summary>
        /// Validador del usuario
        /// </summary>
        IIdentityValidator<ApplicationUser> UserValidator { get; set; }
        /// <summary>
        /// Validador de la contraseña
        /// </summary>
        IIdentityValidator<string> PasswordValidator { get; set; }
        /// <summary>
        /// Define el metodo a implementar para crear un objeto indentity a partir de un usuario
        /// </summary>
        IClaimsIdentityFactory<ApplicationUser, string> ClaimsIdentityFactory { get; set; }
        /// <summary>
        /// Define el metodo para enviar e-mails
        /// </summary>
        IIdentityMessageService EmailService { get; set; }
        /// <summary>
        /// Genera tokens de usuario
        /// </summary>
        IUserTokenProvider<ApplicationUser,string> UserTokenProvider { get; set; }
        /// <summary>
        /// Boleano que identifica si el usuario esta bloqueado
        /// </summary>
        bool UserLockoutEnableByDefault { get; set; }
        /// <summary>
        /// Numero maximo de intentos de acceso
        /// </summary>
        int MaxFailedAccessAttemptsBeforeLockout { get; set; }
        /// <summary>
        /// Tiempo de bloqueo
        /// </summary>
        TimeSpan DefaultLockoutTimeSpan { get; set; }
        /// <summary>
        /// Implementa el Hashing de la contraseña
        /// </summary>
        IPasswordHasher PasswordHasher { get; set; }
    }
}
