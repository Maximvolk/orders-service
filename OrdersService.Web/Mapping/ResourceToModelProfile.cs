using OrdersService.Core.Entities;
using OrdersService.Common.Resources;
using AutoMapper;

namespace OrdersService.Web.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<OrderResource, Order>();
        }
    }
}