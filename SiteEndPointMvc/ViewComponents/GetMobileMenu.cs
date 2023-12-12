using Microsoft.AspNetCore.Mvc;
using SadeghiBasicMarket.Application.Services.Queries.GetMobileMenuItem;

namespace SiteEndPointMvc.ViewComponents
{
    public class GetMobileMenu : ViewComponent
    {
        private readonly IGetMobileMenuItemService _getMobileMenuItemService;
        public GetMobileMenu(IGetMobileMenuItemService getMobileMenuItemService)
        {
            _getMobileMenuItemService = getMobileMenuItemService;
        }


        public IViewComponentResult Invoke()
        {
            var menuItem = _getMobileMenuItemService.Execute();
            return View(viewName: "GetMobileMenu", menuItem.Data);
        }
    }
}
