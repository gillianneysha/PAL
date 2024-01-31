using AutoMapper;
using PAL.DataModel;
using PAL.app.Models;

namespace PAL.app.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<DACSlot, DACSlotVM>().ReverseMap();
          
            CreateMap<AKICSlot, AKICSlotVM>().ReverseMap();
      
            CreateMap<PETERSlot, PETERSlotVM>().ReverseMap();
         
            CreateMap<DOMINGASlot, DOMINGASlotVM>().ReverseMap();
     
            CreateMap<CampusReservation, CampusReservationVM>().ReverseMap();
            //CreateMap<Product, ProductVM>().ReverseMap();
        }
    }
}
