using AutoMapper;
using ElevateEvansville_API.Mapping.Profiles;

namespace ElevateEvansville_API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CoreProfile.Initialize(this);
        }
    }
}
