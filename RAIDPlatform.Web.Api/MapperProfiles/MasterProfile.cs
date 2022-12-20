using AutoMapper;
using RAIDPlatform.Data.Models.Master.Feature_Permissions;
using RAIDPlatform.Web.Api.DTO.MasterDTO;
using RAIDPlatform.Web.Api.DTO.RequestDtos;

namespace RAIDPlatform.Web.Api.MapperProfiles
{
    public class MasterProfile : Profile
    {
        public MasterProfile()
        {
            CreateMap<Feature_Permissions, Feature_Permission_Dto>().ReverseMap();
            CreateMap<Feature_Permissions, UpdateFeaturePermissionDTO>().ReverseMap();
            CreateMap<Feature_Permissions, AddFeaturePermissionDTO>().ReverseMap();
        }
    }
}
