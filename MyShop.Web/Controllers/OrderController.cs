using Microsoft.AspNet.Identity;
using MyShop.Application;
using MyShop.CORE.Domain;
using MyShop.CORE.Enum;
using MyShop.DAL;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class OrderController : Controller
    {
        OrderManager orderManager;
        ApplicationDbContext context;
        ShoppingCartManager shoppingCartManager;
        public OrderController()
        {
            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);
            shoppingCartManager = new ShoppingCartManager(context);
        }
        // GET: Order
        public ActionResult Index()
            //TODO: Me falla el GetUserId
        {
            //var result = User.Identity.GetUserId()//orderManager.GetById/*GetByUserId*/.(User.Identity.GetUserId()).Select(e => new IncidenceList
            //{
            //    Id = e.Id,
            //    Date = e.CreatedDate,
            //    Message = e.Messages.FirstOrDefault().Text,
            //    Status = e.Status.ToString()
            //});
            return View();
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Payment()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Payment(OrderCreate model)
        {
            try
            {
                if (orderManager.CheckCreditCardNumber(model.CardNumber) && orderManager.CheckCreditCardDate(model.Año,model.Mes))
                {
                    return RedirectToAction("PaymentOK");
                }
                else
                {
                    return RedirectToAction("Payment");
                }
                //Order order = new Order
                //{
                //    Status = OrderStatus.Paid,
                //    CreateDate = DateTime.Now,
                //    CardNumber = model.CardNumber,
                //    UserId = User.Identity.GetUserId(),
                //    DeliveryAddressId = null,
                //    OrderLineId = 
                //};
                //OrderLine orderLine = new OrderLine();
                //orderLine = modelCart.Products.Select(e => new ProductViewModel
                //{
                //    Id = e.Id,
                //    Name = e.Name,
                //    Image = e.Image,
                //    Price = e.Price
                //});
                //foreach (var item in shoppingCartManager.GetShoppingCartByUser(User.Identity.GetUserId()))
                //    {
                //        orderLine.ProductName = item.Product.Name;
                //        orderLine.ProductPrice = item.Product.Price;
                //        orderLine.Quantity = item.Quantity;
                //    }
                
                //    return View(model);
                //}
                //return RedirectToAction("Index", "Product");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View();
        }

        public ActionResult PaymentOK()
        {
            return View();
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
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

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
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
