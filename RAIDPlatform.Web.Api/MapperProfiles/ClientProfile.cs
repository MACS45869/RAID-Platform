using AutoMapper;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Web.Api.DTO;

namespace RAIDPlatform.Web.Api.MapperProfiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile() {
            CreateMap<Client_Application_Category, UpdateClientApplicationCategoryDTO>().ReverseMap();
            CreateMap<Client_Application_Category, AddClientApplicationCategoryDTO>().ReverseMap();

        }
    }
}
