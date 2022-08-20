using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    public class ListViewModel
    {
        /// <summary>
        /// Colección de productos
        /// </summary>
        public IQueryable<ProductViewModel> Products { get; set; }
    }
}