using MyShop.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application
{
    /// <summary>
    /// Clase generica para los servicios de aplicación
    /// </summary>
    /// <typeparam name="T">Clase a gestionar</typeparam>
    public class Manager<T>:IManager<T> where T:class
    {
        /// <summary>
        /// Contexto de datos
        /// </summary>
        public IDbContext Context { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Contexto</param>
        public Manager(IDbContext context)
        {
            Context = context;
        }
        /// <inheritdoc/>
        public T GetById(object id)
        {
            return Context.Set<T>().Find(id);
        }
        /// <inheritdoc/>
        public IEnumerable<T> GetByIds(List<object>ids)
        {
            if (ids == null) return null;
            return ids.Select(e => GetById(e));
        }
        /// <inheritdoc/>
        public IQueryable<T>GetAll()
        {
            return Context.Set<T>();
        }
        /// <inheritdoc/>
        public void Remove(T element)
        {
            Context.Set<T>().Remove(element);
        }
        /// <inheritdoc/>
        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
        /// <inheritdoc/>
        public void Add(T element)
        {
            Context.Set<T>().Add(element);
        }
    }
}
