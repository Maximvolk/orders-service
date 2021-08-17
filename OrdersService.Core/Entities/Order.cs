using System;

namespace OrdersService.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string SourceCity { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationAddress { get; set; }
        public decimal Weight { get; set; }
        public DateTime PickUpDate { get; set; }
    }
}