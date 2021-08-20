using System;

namespace OrdersService.Common.Resources
{
    public class OrderResource
    {
        public int Id { get; set; }
        public string SourceCity { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationAddress { get; set; }
        public decimal Weight { get; set; }
        public string PickUpDate { get; set; }
    }
}