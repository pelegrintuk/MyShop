using MyShop.CORE.Domain;
using MyShop.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application
{
    /// <summary>
    /// Manager del producto
    /// </summary>
    public class ProductManager:Manager<Product>,IProductManager
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public ProductManager(IDbContext context):base(context)
        {

        }
    }
}
