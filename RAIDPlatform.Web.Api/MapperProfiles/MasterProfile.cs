using AutoMapper;
using RAIDPlatform.Data.Models.Master.Application_Data_Map;
using RAIDPlatform.Data.Models.Master.Application_Feature_Map;
using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Feature_Permissions;
using RAIDPlatform.Web.Api.DTO.MasterDTO;
using RAIDPlatform.Web.Api.DTO.RequestDtos;
using RAIDPlatform.Web.Api.Minimal;

namespace RAIDPlatform.Web.Api.MapperProfiles
{
    public class MasterProfile : Profile
    {
        public MasterProfile()
        {
            CreateMap<Feature_Permissions, Feature_Permission_Dto>().ReverseMap();
            CreateMap<Feature_Permissions, UpdateFeaturePermissionDTO>().ReverseMap();
            CreateMap<Feature_Permissions, AddFeaturePermissionDTO>().ReverseMap();

            CreateMap<Applications, Applications_Dto>().ReverseMap();
            CreateMap<Applications, MinimalApplicationDto>().ReverseMap();

            CreateMap<Application_Feature_Map, Application_Feature_Map_Dto>().ReverseMap();

            CreateMap<Application_Data_Map, Application_Data_Map_Dto>().ReverseMap();
        }
    }
}
