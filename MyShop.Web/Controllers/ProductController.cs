using MyShop.Application;
using MyShop.CORE.Domain;
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
    public class ProductController : Controller
    {
        ProductManager productManager;
        public ProductController()
        {

        }
        public ProductController(ProductManager productManager)
        {
            this.productManager = productManager;
        }
        //GET: Product
        public ActionResult Index()
        {
            var model = productManager.GetAll();
            return View(model);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                Models.ProductCreate model = null;
                var product = productManager.GetById(id);
                if (product != null)
                {
                    model = new Models.ProductCreate
                    {
                        Name = model.Name,
                        Description = model.Description,
                        Price = model.Price,
                        Stock = model.Stock,
                        Avaliable = model.Avaliable,
                        Image = model.Image
                    };
                    return View(model);
                }
                return RedirectToAction("Index", "Shop");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductCreate model)
        {
            try
            {
                Product product = new Product
                {
                    Name = model.Name,
                    Description = model.Description,
                    Price = model.Price,
                    Stock = model.Stock,
                    Avaliable = model.Avaliable,
                    Image = model.Image
                };
                productManager.Add(product);
                productManager.Context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Models.ProductCreate model = null;
                var product = productManager.GetById(id);
                if (product != null)
                {
                    model = new Models.ProductCreate
                    {
                        Name = model.Name,
                        Description = model.Description,
                        Price = model.Price,
                        Stock = model.Stock,
                        Avaliable = model.Avaliable,
                        Image = model.Image
                    };
                    return View(model);
                }
                return RedirectToAction("Index", "Shop");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductCreate model)
        {
            try
            {
                var product = productManager.GetById(id);
                if (product != null)
                {
                    product.Name = model.Name;
                    product.Description = model.Description;
                    product.Price = model.Price;
                    product.Stock = model.Stock;
                    product.Avaliable = model.Avaliable;
                    product.Image = model.Image;
                    productManager.Context.SaveChanges();
                }
                return RedirectToAction("Index", "Shop");
            }
            catch
            {
                ModelState.AddModelError("", "Se ha producido un error al editar el producto.");
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                Models.ProductCreate model = null;
                var product = productManager.GetById(id);
                if (product != null)
                {
                    model = new Models.ProductCreate
                    {
                        Name = model.Name,
                        Description = model.Description,
                        Price = model.Price,
                        Stock = model.Stock,
                        Avaliable = model.Avaliable,
                        Image = model.Image
                    };
                    return View(model);
                }
                return RedirectToAction("Index", "Shop");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ProductCreate model)
        {
            try
            {
                var product = productManager.GetById(id);
                if (product != null)
                {
                    productManager.Remove(product);
                    productManager.Context.SaveChanges();
                }
                return RedirectToAction("Index", "Shop");
            }
            catch
            {
                ModelState.AddModelError("", "Se ha producido un error al eliminar el producto.");
                return View();
            }
        }
    }
}
