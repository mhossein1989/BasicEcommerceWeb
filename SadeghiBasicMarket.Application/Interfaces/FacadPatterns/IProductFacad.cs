using SadeghiBasicMarket.Application.Services.Commands.AddNewCategory;
using SadeghiBasicMarket.Application.Services.Commands.AddNewProduct;
using SadeghiBasicMarket.Application.Services.Queries.GetAllCategories;
using SadeghiBasicMarket.Application.Services.Queries.GetCategories;
using SadeghiBasicMarket.Application.Services.Queries.GetProductDetailForAdmin;
using SadeghiBasicMarket.Application.Services.Queries.GetProductDetailForSite;
using SadeghiBasicMarket.Application.Services.Queries.GetProductForAdmin;
using SadeghiBasicMarket.Application.Services.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadeghiBasicMarket.Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryService AddNewCategoryService { get; }
        IGetCategoriesService  GetCategoriesService { get; }

        AddNewProductService AddNewProductService { get; }

        IGetAllCategoriesService GetAllCategoriesService { get; }

        IGetProductForAdminService GetProductForAdminService { get; }
        IGetProductDetailForAdminService GetProductDetailForAdminService { get; }

        IGetProductForSiteService GetProductForSiteService { get; }
        IGetProductDetailForSiteService GetProductDetailForSiteService { get; }
    }
}
