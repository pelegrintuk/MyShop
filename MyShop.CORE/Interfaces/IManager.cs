using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Interfaces
{
    /// <summary>
    /// Interfaz del manager
    /// </summary>
    public interface IManager<T>
    {
        /// <summary>
        /// Contexto de datos
        /// </summary>
        IDbContext Context { get; }
        /// <summary>
        /// Se obtiene un elemento por su ID
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>Objeto con el ID indicado</returns>
        T GetById(object id);
        /// <summary>
        /// Obtiene una lista de objetos por sus identificadores
        /// </summary>
        /// <param name="ids">identificadores a buscar</param>
        /// <returns>lista de objetos</returns>
        IEnumerable<T> GetByIds(List<object> ids);
        /// <summary>
        /// Obtiene todos los registros
        /// </summary>
        /// <returns>Lista de todos los registros</returns>
        IQueryable<T> GetAll();
        /// <summary>
        /// Elimina un elemento
        /// </summary>
        /// <param name="element">Elemento a eliminar</param>
        void Remove(T element);
        /// <summary>
        /// Guarda los cambios
        /// </summary>
        /// <returns>devuelve los registros afectados</returns>
        int SaveChanges();
        /// <summary>
        /// Añade un elemento a la colección
        /// </summary>
        /// <param name="element">Elemento a añadir</param>
        void Add(T element);
    }
}
