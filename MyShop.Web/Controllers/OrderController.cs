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
        {
            try
            {
                var model = orderManager.GetAll().Select(e => new OrderViewModel
                {
                    Id = e.Id,
                    StatusId = (int)e.Status,
                    CreateDate = e.CreateDate,
                    SendDate = e.SendDate,
                    DeliveryDate = e.DeliveryDate,
                    CancellationDate = e.CancellationDate,
                    User = e.User.Name,
                    TotalPrice = e.TotalPrice,
                    CardNumber = e.CardNumber
                });
                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                OrderViewModel model = null;
                var order = orderManager.GetById(id);
                if (order != null)
                {
                    model = new OrderViewModel
                    {
                        Id = order.Id,
                        StatusId = (int)order.Status,
                        CreateDate = order.CreateDate,
                        SendDate = order.SendDate,
                        DeliveryDate = order.DeliveryDate,
                        CancellationDate = order.CancellationDate,
                        User = order.UserId,
                        TotalPrice = order.TotalPrice,
                        CardNumber = order.CardNumber
                    };
                    return View(model);
                }
                return RedirectToAction("Index", "Order");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult OrderLineList(int id)
        {
            try
            {
                //var model = orderManager.GetAll().
                //var model = orderManager.GetAll.Select(e => new OrderLineViewModel
                //{
                //    Id = e.Id,
                //    ProductName = e.ProductName,
                //    ProductPrice = e.ProductPrice,
                //    Quantity = e.Quantity
                //});
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                    decimal TotalPriceCart = 0;

                    foreach (var item in shoppingCartManager.GetShoppingCartByUser(User.Identity.GetUserId()))
                    {
                        TotalPriceCart += item.Product.Price * item.Quantity;
                    }

                    Order order = new Order
                    {
                        Status = OrderStatus.Paid,
                        CreateDate = DateTime.Now,
                        CardNumber = model.CardNumber,
                        UserId = User.Identity.GetUserId(),
                        TotalPrice = TotalPriceCart
                    };
                    orderManager.Add(order);
                    orderManager.Context.SaveChanges();

                    var cartList = shoppingCartManager.GetShoppingCartByUser(User.Identity.GetUserId());
                    model.OrderLines = cartList.Select(e => new OrderLineViewModel
                    {
                        ProductName = e.Product.Name,
                        ProductPrice = e.Product.Price,
                        Quantity = e.Quantity,
                    });

                    order.OrderLine = new List<OrderLine>();

                    foreach (var item in model.OrderLines)
                    {
                        order.OrderLine.Add(new OrderLine
                        {
                            ProductName = item.ProductName,
                            ProductPrice = item.ProductPrice,
                            Quantity = item.Quantity,
                            Id = order.OrderLineId
                        });
                    }

                    foreach (var item in cartList)
                    {
                        if (item != null)
                        {
                            shoppingCartManager.Remove(item);
                        }
                    }

                    orderManager.Context.SaveChanges();
                    return RedirectToAction("PaymentOK");
                }
                else
                {
                    return RedirectToAction("Payment");
                }
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
        public ActionResult AddOrderLine(int id, FormCollection collection)
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
