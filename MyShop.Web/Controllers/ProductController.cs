﻿using MyShop.Application;
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
        ApplicationDbContext context = null;
        ProductManager productManager = null;
        public ProductController()
        {
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);
        }
        //GET: Product
        public ActionResult Index()
        {
            var model = new ProductViewModel();

            try
            {
                var products = productManager.GetAll().Select(e => new ProductList
                {
                    Id = e.Id,
                    Name = e.Name,
                    Image = e.Image,
                    Price = e.Price
                }).ToList();
                model.Products = products;
                model.ProductCount = products.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(model);
        }
        //public ActionResult Index()
        //{
        //    //TODO: Resolver esto
        //    //if (productManager.GetAll().Count)
        //    {
        //        var model = productManager.GetAll().Select(e => new ProductList
        //        {
        //            Id = e.Id,
        //            Name = e.Name,
        //            Image = e.Image,
        //            Price = e.Price
        //        });
        //        return View(model);
        //    }
        //    return View();
        //}

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product model)
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
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
