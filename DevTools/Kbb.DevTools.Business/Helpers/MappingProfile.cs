using AutoMapper;
using dto = Kbb.DevTools.Domain.Models;
using db = Kbb.DevTools.DAL.Entities;

namespace Kbb.DevTools.Business.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<dto.Return, db.Return>();
            CreateMap<db.Return, dto.Return>()
                   .ForMember(m => m.UserFullname, opt => opt.Ignore())
                   .ForMember(m => m.UserId, opt => opt.Ignore());

            CreateMap<dto.Address, db.Address>()
                .ReverseMap();

            CreateMap<dto.User, db.User>()
                .ReverseMap();
        }
    }
}
