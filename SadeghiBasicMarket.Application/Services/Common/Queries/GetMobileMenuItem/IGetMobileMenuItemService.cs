using SadeghiBasicMarket.Common.Dto;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SadeghiBasicMarket.Application.Services.Queries.GetMobileMenuItem
{
    public interface IGetMobileMenuItemService
    {
        ResultDto<List<MobileMenuItemDto>> Execute();   
    }
}
