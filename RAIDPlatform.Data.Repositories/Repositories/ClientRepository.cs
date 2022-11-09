using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Security;
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
    public class ClientRepository : IClientRepository
    {
        private readonly DbSet<Client_Application_Category> Client_Application_Category;
        private readonly DbSet<Client_Application_Category_Data_Map> Client_Application_Category_Data_Map;
        private readonly DbSet<Client_Application_Category_Data_Values> Client_Application_Category_Data_Values;
        private readonly DbSet<Client_Application_Security_Group> Client_Application_Security_Group;
        private readonly DbSet<Client_Application_Security_Group_Category_Map> Client_Application_Security_Group_Category_Map;
        private readonly DbSet<Client_Application_Security_Group_Feature_Map> Client_Application_Security_Group_Feature_Map;
        private readonly DbSet<Client_Data> Client_Data;
        private readonly DbSet<Client_Features> Client_Features;
        private readonly DbSet<Client_Module_Map> Client_Module_Map;
        private readonly DbSet<Client_Navigation_Feature_Map> Client_Navigation_Feature_Map;
        private readonly DbSet<Client_Navigations> Client_Navigations;
        private readonly DbSet<Client_Parameter_Values> Client_Parameter_Values;
        private readonly DbSet<Client_Parameters> Client_Parameters;
        private readonly DbSet<Clients> Clients;
        private readonly DbSet<User_Category_Map> User_Category_Map;
        private readonly DbSet<User_Security_Group_Map> User_Security_Group_Map;
        private readonly DbSet<Users> Users;

        private readonly ClientContext context;

        public ClientRepository(ClientContext context)
        {
            this.context = context;
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
            Client_Navigations = context.client_Navigation;
            Users = context.Users;
        }

        public Task<int> AddUsers(Users users)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUsers(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Users>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUsersById(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateUser(Users users)
        {
            throw new NotImplementedException();
        }
    }
}
