﻿using System.Collections.Generic;

namespace SadeghiBasicMarket.Application.Services.Carts
{
    public class CartDto
    {
        public long CartId { get; set; }
        public int ProductCount { get; set; }
        public int SumAmount { get; set; }
        public List<CartItemDto> CartItems { get; set; }
    }
}
