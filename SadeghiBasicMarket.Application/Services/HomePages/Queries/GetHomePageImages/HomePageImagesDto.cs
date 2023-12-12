using SadeghiBasicMarket.Domain.Entities;

namespace SadeghiBasicMarket.Application.Services.Queries.GetHomePageImages
{
    public class HomePageImagesDto
    {
        public long Id { get; set; }
        public string Src { get; set; }
        public string Link { get; set; }
        public ImageLocation ImageLocation { get; set; }
    }
}
