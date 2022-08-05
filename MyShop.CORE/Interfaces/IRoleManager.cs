using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Interfaces
{
    /// <summary>
    /// Intefaz para el manager de roles
    /// </summary>
    public interface IRoleManager :IDisposable
    {
        /// <summary>
        /// Validador del rol de ususario
        /// </summary>
        IIdentityValidator<IdentityRole> RoleValidator { get; set; }
        /// <summary>
        /// Devuelve los registros de los roles disponibles
        /// </summary>
        IQueryable<IdentityRole> Roles { get; }
        /// <summary>
        /// Crea un rol
        /// </summary>
        /// <param name="role">rol a crear</param>
        /// <returns></returns>
        Task<IdentityResult> CreateAsync(IdentityRole role);
        /// <summary>
        /// Borra un rol
        /// </summary>
        /// <param name="role">rol a borrar</param>
        /// <returns></returns>
        Task<IdentityResult> CDeleteAsync(IdentityRole role);
        /// <summary>
        /// Devuelve el rol por el ID
        /// </summary>
        /// <param name="roleId">Identificador</param>
        /// <returns></returns>
        Task<IdentityRole> FindByIdAsync(string roleId);
        /// <summary>
        /// Devuelve el rol por el nombre
        /// </summary>
        /// <param name="roleName">Nombre del rol</param>
        /// <returns></returns>
        Task<IdentityRole> FindByNameAsync(string roleName);
        /// <summary>
        /// Devuelve si el rol existe por el nombre
        /// </summary>
        /// <param name="roleName">Nombre del rol</param>
        /// <returns></returns>
        Task<bool> RoleExistAsync(string roleName);
        /// <summary>
        /// Actrualiza un rol
        /// </summary>
        /// <param name="role">rol</param>
        /// <returns></returns>
        Task<IdentityResult> UpdateAsync(IdentityRole role);
    }
}
