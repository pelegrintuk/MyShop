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
    /// Manager de los pedidos
    /// </summary>
    public class OrderManager:Manager<Order>,IOrderManager
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public OrderManager(IDbContext context):base(context)
        {

        }
    }
}
