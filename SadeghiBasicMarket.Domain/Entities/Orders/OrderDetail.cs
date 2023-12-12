using SadeghiBasicMarket.Domain.Entities.Commons;

namespace SadeghiBasicMarket.Domain.Entities
{
    public class OrderDetail:BaseEntity
    {
        public virtual Order Order { get; set; }
        public long OrderId { get; set; }

        public virtual Product Product { get; set; }
        public long ProductId { get; set; }

        public int Price { get; set; }
        public int Count { get; set; }
    }

}
