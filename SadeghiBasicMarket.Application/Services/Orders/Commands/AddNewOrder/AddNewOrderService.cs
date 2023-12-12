﻿using SadeghiBasicMarket.Application.Interfaces.Contexts;
using SadeghiBasicMarket.Common.Dto;
using SadeghiBasicMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SadeghiBasicMarket.Application.Services.Commands.AddNewOrder
{
    public class AddNewOrderService : IAddNewOrderService
    {
        private readonly IDataBaseContext _context;
        public AddNewOrderService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestAddNewOrderServiceDto request)
        {
            var user = _context.Users.Find(request.UserId);
            var requestPay = _context.RequestPays.Find(request.RequestPayId);
            var cart = _context.Carts.Include(p => p.CartItems)
                .ThenInclude(p=> p.Product)
                .Where(p => p.Id == request.CartId).FirstOrDefault();

            requestPay.IsPay = true;
            requestPay.PayDate = DateTime.Now;

            cart.Finished = true;

            Order order = new Order()
            {
                Address = "",
                OrderState = OrderState.Processing,
                RequestPay = requestPay,
                User = user,

            };
            _context.Orders.Add(order);

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var item in cart.CartItems)
            {

                OrderDetail orderDetail = new OrderDetail()
                {
                    Count = item.Count,
                    Order = order,
                    Price = item.Product.Price,
                    Product = item.Product,
                };
                orderDetails.Add(orderDetail);
            }


            _context.OrderDetails.AddRange(orderDetails);

            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "",
            };
        }
    }
}
