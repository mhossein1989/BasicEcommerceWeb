using SadeghiBasicMarket.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace SadeghiBasicMarket.Application.Services.Commands.AddHomePageImages
{
    public class requestAddHomePageImagesDto
    {
        public IFormFile      file { get; set; }
        public string Link { get; set; }
        public ImageLocation ImageLocation{ get; set; }
    }
}
