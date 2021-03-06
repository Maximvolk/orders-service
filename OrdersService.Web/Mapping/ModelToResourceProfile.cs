using OrdersService.Core.Entities;
using OrdersService.Common.Resources;
using AutoMapper;

namespace OrdersService.Web.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Order, OrderResource>()
                .ForMember(dest => dest.PickUpDate, opt => opt.MapFrom(src => src.PickUpDate.ToString("MM/dd/yyyy")));
        }
    }
}