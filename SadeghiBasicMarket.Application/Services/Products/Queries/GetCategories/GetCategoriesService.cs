﻿using Microsoft.EntityFrameworkCore;
using SadeghiBasicMarket.Application.Interfaces.Contexts;
using SadeghiBasicMarket.Common.Dto;
using System.Collections.Generic;
using System.Linq;

namespace SadeghiBasicMarket.Application.Services.Queries.GetCategories
{
    public class GetCategoriesService : IGetCategoriesService
    {
        private readonly IDataBaseContext _context;

        public GetCategoriesService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<CategoriesDto>> Execute(long? ParentId)
        {
            var categories = _context.Categories
               .Include(p => p.ParentCategory)
               .Include(p => p.SubCategories)
               .Where(p => p.ParentCategoryId == ParentId)
               .ToList()
               .Select(p => new CategoriesDto
               {
                   Id = p.Id,
                   Name = p.Name,
                   Parent = p.ParentCategory != null ? new
                   ParentCategoryDto
                   {
                       Id = p.ParentCategory.Id,
                       name = p.ParentCategory.Name,
                   }
                   : null,
                   HasChild = p.SubCategories.Count() > 0 ? true : false,
                   SubCategories = p.SubCategories.Select(s => new CategoriesDto
                   {
                       Id = s.Id,
                       Name = s.Name,
                       Parent = s.ParentCategory != null ? new
                   ParentCategoryDto
                       {
                           Id = s.ParentCategory.Id,
                           name = s.ParentCategory.Name,
                       }
                   : null,
                      
                   }).ToList() ,
               }).ToList();


            return new ResultDto<List<CategoriesDto>>()
            {
                Data = categories,
                IsSuccess = true,
                Message = "لیست باموقیت برگشت داده شد"
            };

        }
    }
}



