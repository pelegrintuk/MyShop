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
        ShoppingCartManager shopingCartManager;
        ApplicationDbContext context;
        public ProductController()
        {
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);
            shopingCartManager = new ShoppingCartManager(context);
        }
        //public ProductController(ProductManager productManager)
        //{
        //    this.productManager = productManager;
        //}
        //GET: Product
        //public ActionResult Index()
        //{
        //    var model = productManager.GetAll();
        //    return View(model);0 
        //}
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
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Stock = product.Stock,
                        Avaliable = product.Avaliable,
                        Image = product.Image
                    };
                    return View(model);
                }
                return RedirectToAction("Index", "Product");
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
                    Avaliable = 0<model.Stock,
                    Image = model.Image
                };
                productManager.Add(product);
                productManager.Context.SaveChanges();

                return RedirectToAction("Index", "Product");
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
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Stock = product.Stock,
                        Avaliable = product.Avaliable,
                        Image = product.Image
                    };
                    return View(model);
                }
                return RedirectToAction("Index", "Product");
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
                    product.Avaliable = 0<model.Stock;
                    product.Image = model.Image;
                    productManager.Context.SaveChanges();
                }
                return RedirectToAction("Index", "Product");
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
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Stock = product.Stock,
                        Avaliable = product.Avaliable,
                        Image = product.Image
                    };
                    return View(model);
                }
                return RedirectToAction("Index", "Product");
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
                return RedirectToAction("Index", "Product");
            }
            catch
            {
                ModelState.AddModelError("", "Se ha producido un error al eliminar el producto.");
                return View();
            }
        }
    }
}
