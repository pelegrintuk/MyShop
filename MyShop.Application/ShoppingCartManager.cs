using MyShop.CORE.Domain;
using MyShop.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyShop.Application
{
    /// <summary>
    /// Manager del carrito de la compra
    /// </summary>
    public class ShoppingCartManager : Manager<ShoppingCart>, IShoppingCartManager
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public ShoppingCartManager(IDbContext context) : base(context)
        {
        }
        /// <inheritdoc/>
        public int AddProduct(string userId, int productId, int quantity)
        {
            var query = GetShoppingCartByUser(userId).Where(e => e.ProductId == productId);
            if (query.Any())
            {
                query.Single().Quantity = query.Single().Quantity + quantity;
                query.Single().Date = DateTime.Now;
            }
            else
            {
                this.Context.ShoppingCart.Add(new ShoppingCart
                {
                    Date = DateTime.Now,
                    ProductId = productId,
                    Quantity = quantity,
                    UserId = userId,
                });
            }
            this.Context.SaveChanges();
            return GetShoppingCartByUser(userId).Sum(e => e.Quantity);
        }

        /// <inheritdoc/>
        public IQueryable<ShoppingCart> GetShoppingCartByUser(string userId)
        {
            var query = GetAll().Include(e => e.Product).Where(e => e.UserId == userId);
            return query;
        }
    }
}
