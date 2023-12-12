﻿using SadeghiBasicMarket.Application.Interfaces.Contexts;
using SadeghiBasicMarket.Common.Dto;
using System.Collections.Generic;
using System.Linq;

namespace SadeghiBasicMarket.Application.Services.Queries.GetSlider
{
    public class GetSliderService : IGetSliderService
    {
        private readonly IDataBaseContext _context;
        public GetSliderService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<SliderDto>> Execute()
        {
            var sliders = _context.Sliders.OrderByDescending(p => p.Id).ToList().Select(
                p => new SliderDto
                {
                    Link=p.link,
                    Src=p.Src,
                }).ToList();

            return new ResultDto<List<SliderDto>>()
            {
                Data = sliders,
                IsSuccess = true,
            };
        }
    }
}
