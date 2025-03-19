﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyWebApp.Models;
using MyWebApp.Models.ViewModels;
using MyWebApp.Repository;

namespace MyWebApp.Areas.Admin.Controllers
{ 
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly DataContext _dataContext;
        public CheckoutController(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<IActionResult> Checkout()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            if (userEmail == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var ordercode = Guid.NewGuid().ToString();
                var orderItem = new OrderModel
                {
                    OrderCode = ordercode,
                    UserName = userEmail,
                    Status = 1,
                    CreatedDate = DateTime.Now
                };
                _dataContext.Add(orderItem);
                await _dataContext.SaveChangesAsync(); // Use async method

                List<CartItemModel> cartItems = HttpContext.Session.GetJson<List<CartItemModel>>("Cart") ?? new List<CartItemModel>();
                foreach (var cart in cartItems)
                {
                    var orderdetails = new OrderDetails
                    {
                        UserName = userEmail,
                        OrderCode = ordercode,
                        ProductId = cart.ProductId,
                        Price = cart.Price,
                        Quantity = cart.Quantity
                    };
                    _dataContext.Add(orderdetails);
                    await _dataContext.SaveChangesAsync(); // Use async method
                }
                HttpContext.Session.Remove("Cart");
                TempData["success"] = "Checkout thành công, vui lòng chờ duyệt đơn hàng";
                return RedirectToAction("Index", "Cart");
            }
            return View();
        }
    }
}