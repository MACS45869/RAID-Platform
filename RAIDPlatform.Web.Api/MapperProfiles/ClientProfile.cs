using AutoMapper;
using RAIDPlatform.Data.Models.Client;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Category_Map;
using RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Feature_Map;
using RAIDPlatform.Data.Models.Client.Client_Features;
using RAIDPlatform.Data.Models.Client.Clients;
using RAIDPlatform.Data.Models.Client.User_Security_Group_Map;
using RAIDPlatform.Data.Models.Client.Users;
using RAIDPlatform.Web.Api.DTO;
using RAIDPlatform.Web.Api.DTO.ClientDTO;
using RAIDPlatform.Web.Api.DTO.RequestDtos;
using RAIDPlatform.Web.Api.Minimal;

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
            CreateMap<Client_Application_Security_Group, MinimalClientApplicationSecurityGroupDto>().ReverseMap();


            CreateMap<Users, Users_Dto>().ReverseMap();
            CreateMap<Users, UpdateUsersDTO>().ReverseMap();
            CreateMap<Users, AddUsersDTO>().ReverseMap();

            CreateMap<Clients, Clients_Dto>().ReverseMap();

            CreateMap<User_Security_Group_Map, User_Security_Group_Map_Dto>().ReverseMap();
            CreateMap<Client_Application_Security_Group_Category_Map, Client_Application_Security_Group_Category_Map_Dto>().ReverseMap();
            CreateMap<Client_Application_Security_Group_Feature_Map, Client_Application_Security_Group_Feature_Map_Dto>().ReverseMap();
            CreateMap<Client_Features_Dto, Client_Features>().ReverseMap();
        }
    }
}
