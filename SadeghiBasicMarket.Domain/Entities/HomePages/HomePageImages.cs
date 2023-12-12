using SadeghiBasicMarket.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadeghiBasicMarket.Domain.Entities
{
    public class HomePageImages:BaseEntity
    {
        public string Src { get; set; }
        public string link { get; set; }
        public ImageLocation  ImageLocation { get; set; }
    }

}
