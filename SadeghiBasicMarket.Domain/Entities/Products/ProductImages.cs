using SadeghiBasicMarket.Domain.Entities.Commons;

namespace SadeghiBasicMarket.Domain.Entities
{
    public class ProductImages : BaseEntity
    {
        public virtual Product Product { get; set; }
        public long ProductId { get; set; }
        public string Src { get; set; }
    }
}
