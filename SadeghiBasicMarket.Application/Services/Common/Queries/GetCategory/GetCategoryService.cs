﻿using SadeghiBasicMarket.Application.Interfaces.Contexts;
using SadeghiBasicMarket.Common.Dto;
using System.Collections.Generic;
using System.Linq;

namespace SadeghiBasicMarket.Application.Services.Queries.GetCategory
{
    public class GetCategoryService : IGetCategoryService
    {
        private readonly IDataBaseContext _context;
        public GetCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<CategoryDto>> Execute()
        {

            var category = _context.Categories.Where(p => p.ParentCategoryId == null)
                .ToList()
                .Select(p => new CategoryDto
                {
                    CatId = p.Id,
                    CategoryName = p.Name,
                }).ToList();

            return new ResultDto<List<CategoryDto>>()
            {
                Data = category,
                IsSuccess = true,
            };
        }
    }
}
