using SadeghiBasicMarket.Common.Dto;
using SadeghiBasicMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SadeghiBasicMarket.Application.Services.Queries.GetSlider
{
    public interface IGetSliderService
    {
        ResultDto<List<SliderDto>> Execute();
    }
}
