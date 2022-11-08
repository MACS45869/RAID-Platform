using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Model.Client;
using RAIDPlatform.Data.Model.Client.Client_Application_Category;
using RAIDPlatform.Data.Model.Client.Client_Application_Category_Data_Map;
using RAIDPlatform.Data.Model.Client.Client_Application_Category_Data_Values;
using RAIDPlatform.Data.Model.Client.Client_Application_Security_Group_Category_Map;
using RAIDPlatform.Data.Model.Client.Client_Application_Security_Group_Feature_Map;
using RAIDPlatform.Data.Model.Client.Client_Data;
using RAIDPlatform.Data.Model.Client.Client_Features;
using RAIDPlatform.Data.Model.Client.Client_Module_Map;
using RAIDPlatform.Data.Model.Client.Client_Navigation_Feature_Map;
using RAIDPlatform.Data.Model.Client.Client_Navigations;
using RAIDPlatform.Data.Model.Client.Client_Parameter_Values;
using RAIDPlatform.Data.Model.Client.Client_Parameters;
using RAIDPlatform.Data.Model.Client.Clients;
using RAIDPlatform.Data.Model.Client.User_Category_Map;
using RAIDPlatform.Data.Model.Client.User_Security_Group_Map;
using RAIDPlatform.Data.Model.Client.Users;
using RAIDPlatform.Data.Repositories.Base;
using RAIDPlatform.Data.Repositories.Context;
using RAIDPlatform.Data.Repositories.Interfaces;

namespace RAIDPlatform.Data.Repositories.Repositories
{
    public class ClientRepository : BaseRepository<Clients, ClientContext>, IClientRepository
    {
        private DbSet<Client_Application_Category> Client_Application_Category;
        private DbSet<Client_Application_Category_Data_Map> Client_Application_Category_Data_Map;
        private DbSet<Client_Application_Category_Data_Values> Client_Application_Category_Data_Values;
        private DbSet<Client_Application_Security_Group> Client_Application_Security_Group;
        private DbSet<Client_Application_Security_Group_Category_Map> Client_Application_Security_Group_Category_Map;
        private DbSet<Client_Application_Security_Group_Feature_Map> Client_Application_Security_Group_Feature_Map;
        private DbSet<Client_Data> Client_Data;
        private DbSet<Client_Features> Client_Features;
        private DbSet<Client_Module_Map> Client_Module_Map;
        private DbSet<Client_Navigation_Feature_Map> Client_Navigation_Feature_Map;
        private DbSet<Client_Navigations> Client_Navigations;
        private DbSet<Client_Parameter_Values> Client_Parameter_Values;
        private DbSet<Client_Parameters> Client_Parameters;
        private DbSet<Clients> Clients;
        private DbSet<User_Category_Map> User_Category_Map;
        private DbSet<User_Security_Group_Map> User_Security_Group_Map;
        private DbSet<Users> Users;

        public ClientRepository(IUnitOfWork<ClientContext> uow) : base(uow)
        {
            var context = (ClientContext)uow.Context;
            Client_Application_Category = context.client_Application_Categories;
            Client_Application_Category_Data_Map = context.client_Application_Category_Data_Maps;
            Client_Application_Category_Data_Values = context.client_Application_Category_Data_Values;
            Client_Application_Security_Group = context.client_Application_Security_Groups;
            Client_Application_Security_Group_Category_Map = context.client_Application_Security_Group_Category_Map;
            Client_Application_Security_Group_Feature_Map = context.client_Application_Security_Group_Feature_Map;
            Client_Data = context.client_Data;
            Client_Features = context.client_Feature;
            Client_Module_Map = context.client_Module_Map;
            Client_Navigation_Feature_Map = context.client_Navigation_Feature_Map;
            Client_Parameter_Values = context.client_Parameter_Value;
            Client_Parameters = context.client_Parameters;
            Clients = context.clients;
            User_Category_Map = context.user_Category_Map;
            User_Security_Group_Map = context.user_Security_Group_Map;
            Users = context.Users;
        }

        
    }
}
