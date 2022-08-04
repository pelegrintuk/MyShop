using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.CORE.Enum
{
    /// <summary>
    /// Enumerado de estados del pedido
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Pedido pendiente
        /// </summary>
        Pending,
        /// <summary>
        /// Pedido pagado
        /// </summary>
        Paid,
        /// <summary>
        /// Pedido en proceso
        /// </summary>
        InProcess,
        /// <summary>
        /// Pedido enviado
        /// </summary>
        Send,
        /// <summary>
        /// Pedido finalizado
        /// </summary>
        End,
        /// <summary>
        /// Pedido cancelado
        /// </summary>
        Canceled
    }
}
