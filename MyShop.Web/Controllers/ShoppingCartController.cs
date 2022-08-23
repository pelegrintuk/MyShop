using Microsoft.AspNet.Identity;
using MyShop.Application;
using MyShop.CORE.Domain;
using MyShop.DAL;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        ProductManager productManager;
        ShoppingCartManager shopingCartManager;
        ApplicationDbContext context;
        public ShoppingCartController()
        {
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);
            shopingCartManager = new ShoppingCartManager(context);
        }
        //GET: Cart
        public ActionResult GetCart()
        {
            ListViewModel model = new ListViewModel();
            try
            {
                model.Products = shopingCartManager.GetShoppingCartByUser(User.Identity.GetUserId()).Select(e => new ProductViewModel
                {
                    Id = e.Id,
                    Name = e.Product.Name,
                    Image = e.Product.Image,
                    Price = e.Product.Price,
                    Quantity = e.Quantity
                });
                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult Add(int id,int quantity = 1)
        {
           try
            {
                shopingCartManager.AddProduct(User.Identity.GetUserId(), id, quantity);
                return RedirectToAction("Index", "Product");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult Delete(int productId)
        {
            return View();
        }
    }
}
