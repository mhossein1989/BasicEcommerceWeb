using SadeghiBasicMarket.Domain.Entities;
using System.Collections.Generic;

namespace SadeghiBasicMarket.Application.Services.Queries.GetUserOrders
{
    public class GetUserOrdersDto
    {
        public long OrderId { get; set; }
        public OrderState OrderState { get; set; }
        public long RequestPayId { get; set; }
        public List<OrderDetailsDto> OrderDetails { get; set; }
    }
}
