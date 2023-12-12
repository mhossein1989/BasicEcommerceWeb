namespace SadeghiBasicMarket.Application.Services.Commands.AddNewOrder
{
    public class RequestAddNewOrderServiceDto
    {
        public long CartId { get; set; }
        public long RequestPayId { get; set; }
        public long UserId { get; set; }

    }
}
