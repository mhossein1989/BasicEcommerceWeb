using SadeghiBasicMarket.Application.Interfaces.Contexts;
using SadeghiBasicMarket.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SadeghiBasicMarket.Domain.Entities;

namespace SadeghiBasicMarket.Application.Services.Queries.GetMobileMenuItem
{
    public class GetMobileMenuItemService : IGetMobileMenuItemService
    {
        private readonly IDataBaseContext _context;
        public GetMobileMenuItemService(IDataBaseContext context)
        {
            _context = context;
        }

        private List<MobileMenuItemDto> CreateVM(long? parentid, IDataBaseContext contxt)
        {

            var cats = contxt.Categories
                .Include(p => p.SubCategories)
                .Where(p => p.ParentCategoryId == parentid)
                .ToList()
                .Select(p => new MobileMenuItemDto
                {
                    CatId = p.Id,
                    Name = p.Name,
                    Child =CreateVM(p.Id , contxt)
                    //Child = p.SubCategories.ToList().Select(child => new MenuItemDto
                    //{
                    //    CatId = child.Id,
                    //    Name = child.Name,
                    //}).ToList(),
                }).ToList();

            return cats;


            //return from men in source
            //       where men.ParentId = parentid
            //       select new MenuViewModel()
            //       {
            //           MenuId = men.MenuId,
            //           Name = men.Name
            //                  // other properties
            //          Children = CreateVM(men.MenuId, source)
            //       };
        }

        public ResultDto<List<MobileMenuItemDto>> Execute()
        {

            var category = CreateVM(null, _context);

            
            return new ResultDto<List<MobileMenuItemDto>>()
            {
                Data = category,
                IsSuccess = true,
            };
        }
    }
}
