using System.Collections.Generic;

namespace SadeghiBasicMarket.Application.Services.Queries.GetMobileMenuItem
{
    public class MobileMenuItemDto
    {
        public long CatId { get; set; }
        public string Name { get; set; }
        public List<MobileMenuItemDto> Child { get; set; }
    }
}
