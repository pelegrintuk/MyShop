using MyShop.CORE.Domain;
using MyShop.CORE.Enum;
using MyShop.CORE.Interfaces;
using MyShop.DAL;
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
        public bool CheckCreditCardNumber(string digits)
        {
            return digits.All(char.IsDigit) && digits.Reverse()
                .Select(c => c - 48)
                .Select((thisNum, i) => i % 2 == 0
                    ? thisNum
                    : ((thisNum *= 2) > 9 ? thisNum - 9 : thisNum)
                ).Sum() % 10 == 0;
        }
        public bool CheckCreditCardDate(int año, int mes)
        {
            if (año > DateTime.Today.Year) return true;
            else if (año == DateTime.Today.Year && mes >= DateTime.Today.Month) return true;
            else return false;
        }
        public string GetStatus(OrderStatus status)
        {
            string Valor = Enum.GetName(typeof(OrderStatus), status);
            return Valor;
        }
    }
}
