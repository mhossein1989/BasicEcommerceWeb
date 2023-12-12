using SadeghiBasicMarket.Domain.Entities;
using System.Collections.Generic;

namespace SadeghiBasicMarket.Application.Services.Queries.GetCategories
{
    public class CategoriesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public ParentCategoryDto Parent { get; set; }
        //sadeghi
        public  List<CategoriesDto> SubCategories { get; set; }


    }
}



