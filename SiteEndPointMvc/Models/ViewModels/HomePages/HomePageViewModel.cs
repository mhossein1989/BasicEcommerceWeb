using SadeghiBasicMarket.Application.Services.Queries.GetHomePageImages;
using SadeghiBasicMarket.Application.Services.Queries.GetSlider;
using SadeghiBasicMarket.Application.Services.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteEndPointMvc.Models.ViewModels
{
    public class HomePageViewModel
    {
        public List<SliderDto> Sliders {get;set;}
        public List<HomePageImagesDto> PageImages { get; set; }
        public List<ProductForSiteDto>  Camera { get; set; }
        public List<ProductForSiteDto>  Mobile { get; set; }
        public List<ProductForSiteDto>  Laptop { get; set; }
    }
}
