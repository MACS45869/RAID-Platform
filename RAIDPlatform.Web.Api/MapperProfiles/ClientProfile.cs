using AutoMapper;
using RAIDPlatform.Data.Models.Client;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Users;
using RAIDPlatform.Web.Api.DTO;
using RAIDPlatform.Web.Api.DTO.ClientDTO;
using RAIDPlatform.Web.Api.DTO.RequestDtos;

namespace RAIDPlatform.Web.Api.MapperProfiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile() {

            CreateMap<Client_Application_Category, Client_Application_Category_Dto>().ReverseMap();
            CreateMap<Client_Application_Category, UpdateClientApplicationCategoryDTO>().ReverseMap();
            CreateMap<Client_Application_Category, AddClientApplicationCategoryDTO>().ReverseMap();

            CreateMap<Client_Application_Security_Group, Client_Application_Security_Group_Dto>().ReverseMap();
            CreateMap<Client_Application_Security_Group, UpdateClientApplicationSecurityGroupDTO>().ReverseMap();
            CreateMap<Client_Application_Security_Group, AddClientApplicationSecurityGroupDTO>().ReverseMap();

            CreateMap<Users, Users_Dto>().ReverseMap();
            CreateMap<Users, UpdateUsersDTO>().ReverseMap();
            CreateMap<Users, AddUsersDTO>().ReverseMap();
        }
    }
}
