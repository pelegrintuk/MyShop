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
        ShoppingCartManager shoppingCartManager;
        ApplicationDbContext context;
        public ShoppingCartController()
        {
            context = new ApplicationDbContext();
            shoppingCartManager = new ShoppingCartManager(context);
        }
        //GET: Cart
        public ActionResult GetCart()
        {
            ListViewModel model = new ListViewModel();
            try
            {
                model.Products = shoppingCartManager.GetShoppingCartByUser(User.Identity.GetUserId()).Select(e => new ProductViewModel
                {
                    Id = e.Id,
                    Name = e.Product.Name,
                    Image = e.Product.Image,
                    Price = e.Product.Price,
                    Quantity = e.Quantity
                });
                model.TotalPrice = 0;
                foreach (var item in model.Products)
                {
                    model.TotalPrice += item.Price * item.Quantity;
                }
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
                shoppingCartManager.AddProduct(User.Identity.GetUserId(), id, quantity);
                return RedirectToAction("Index", "Product");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                var product = shoppingCartManager.GetById(id);
                if (product != null)
                {
                    shoppingCartManager.Remove(product);
                    shoppingCartManager.Context.SaveChanges();
                }
                return RedirectToAction("GetCart", "ShoppingCart");
            }
            catch
            {
                ModelState.AddModelError("", "Se ha producido un error al eliminar el producto del carrito.");
                return View();
            }
        }
    }
}
