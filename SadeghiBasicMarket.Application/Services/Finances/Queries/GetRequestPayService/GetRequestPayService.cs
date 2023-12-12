﻿using SadeghiBasicMarket.Application.Interfaces.Contexts;
using SadeghiBasicMarket.Common.Dto;
using System;
using System.Linq;

namespace SadeghiBasicMarket.Application.Services.Queries.GetRequestPayService
{
    public class GetRequestPayService : IGetRequestPayService
    {
        private readonly IDataBaseContext _context;
        public GetRequestPayService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<RequestPayDto> Execute(Guid guid)
        {
            var requestPay = _context.RequestPays.Where(p => p.Guid == guid).FirstOrDefault();

            if (requestPay != null)
            {
                return new ResultDto<RequestPayDto>()
                {
                    Data = new RequestPayDto()
                    {
                        Id = requestPay.Id,
                        Amount = requestPay.Amount,
                    }
                };
            }
            else
            {
                throw new Exception("request pay not found");
            }
        }
    }
}
