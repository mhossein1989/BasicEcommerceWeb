﻿using System;

namespace SadeghiBasicMarket.Application.Services.Commands.AddRequestPay
{
    public class ResultRequestPayDto
    {
        public Guid guid { get; set; }

        public int Amount { get; set; }
        public string Email { get; set; }
        public long RequestPayId { get; set; }
    }
}
