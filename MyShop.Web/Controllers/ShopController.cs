using MyShop.Application;
using MyShop.CORE.Interfaces;
using MyShop.DAL;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class ShopController : Controller
    {
        ProductManager productManager;
        ShoppingCartManager shopingCartManager;
        ApplicationDbContext context;
        public ShopController()
        {
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);
            shopingCartManager = new ShoppingCartManager(context);

        }
        //public ShopController(ProductManager productManager, ShoppingCartManager shopingCartManager)
        //{
        //    this.productManager = productManager;
        //    this.shopingCartManager = shopingCartManager;
        //}
        // GET: Shop
        public ActionResult Index()
        {
            ListViewModel model = new ListViewModel();           
            try
            {
                model.Products = productManager.GetAll().Select(e => new ProductViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Image = e.Image,
                    Price = e.Price
                });
                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Shop/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shop/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shop/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shop/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
