using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Math.EC.Rfc7748;
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
using RAIDPlatform.Data.Model.Master.Applications;
using RAIDPlatform.Data.Repositories.Base;
using RAIDPlatform.Data.Repositories.Context;
using RAIDPlatform.Data.Repositories.Interfaces;
using System;

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
        public async Task<List<Clients>> GetAllClient()
        {
            var clients = await Clients.ToListAsync();
            return clients;
        }
        public async Task<Clients> GetClientsByID(int clientId)
        {
            var _qs = await Clients

               .Where(x => x.Client_ID == clientId).FirstOrDefaultAsync();

            return _qs;
        }
        public async Task<int> AddClient(Clients clients)
        {
            var rec = new Clients()
            {
                
                Client_Name = clients.Client_Name,
                Client_Key = clients.Client_Key,
                Client_Description = clients.Client_Description,
                Primary_Address = clients.Primary_Address,
                Primary_Email = clients.Primary_Email,
                Primary_Landline = clients.Primary_Landline,
                Primary_Cell = clients.Primary_Cell,
                Primary_Contact_Name = clients.Primary_Contact_Name,
                Primary_Contact_Email = clients.Primary_Contact_Email,
                Primary_Contact_Landline = clients.Primary_Contact_Landline,
                Primary_Contact_Cell = clients.Primary_Contact_Cell,
                Secondary_Contact_Name = clients.Secondary_Contact_Name,
                Secondary_Contact_Email = clients.Secondary_Contact_Email,
                Secondary_Contact_Landline = clients.Secondary_Contact_Landline,
                Secondary_Contact_Cell = clients.Secondary_Contact_Cell,
                Status_ID = clients.Status_ID,
                Status_Value = clients.Status_Value,
                Created_By_ID = clients.Created_By_ID,
                Created_By_Name = clients.Created_By_Name,
                Created_Date = clients.Created_Date,
                Updated_By_ID = clients.Updated_By_ID,
                Updated_By_Name = clients.Updated_By_Name,
                Updated_Date = clients.Updated_Date
            };
            context.clients.Add(rec);
            await context.SaveChangesAsync();

            return clients.Client_ID;
        }
        public async Task UpdateClients(int clientId, Clients clients)
        {
            var ua = await context.clients.FindAsync(clientId);
            if (ua != null)
            {

                ua.Client_Name = clients.Client_Name;
                ua.Client_Key = clients.Client_Key;
                ua.Client_Description = clients.Client_Description;
                ua.Primary_Address = clients.Primary_Address;
                ua.Primary_Email = clients.Primary_Email;
                ua.Primary_Landline = clients.Primary_Landline;
                ua.Primary_Cell = clients.Primary_Cell;
                ua.Primary_Contact_Name = clients.Primary_Contact_Name;
                ua.Primary_Contact_Email = clients.Primary_Contact_Email;
                ua.Primary_Contact_Landline = clients.Primary_Contact_Landline;
                ua.Primary_Contact_Cell = clients.Primary_Contact_Cell;
                ua.Secondary_Contact_Name = clients.Secondary_Contact_Name;
                ua.Secondary_Contact_Email = clients.Secondary_Contact_Email;
                ua.Secondary_Contact_Landline = clients.Secondary_Contact_Landline;
                ua.Secondary_Contact_Cell = clients.Secondary_Contact_Cell;
                ua.Status_ID = clients.Status_ID;
                ua.Status_Value = clients.Status_Value;
                ua.Created_By_ID = clients.Created_By_ID;
                ua.Created_By_Name = clients.Created_By_Name;
                ua.Created_Date = clients.Created_Date;
                ua.Updated_By_ID = clients.Updated_By_ID;
                ua.Updated_By_Name = clients.Updated_By_Name;
                ua.Updated_Date = clients.Updated_Date;

                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteClients(int clientId)
        {
            var ca = new Clients() { Client_ID = clientId };

            context.clients.Remove(ca);
            await context.SaveChangesAsync();
        }
        public async Task<List<Client_Application_Category>> GetAllClientApplicationCategory()
        {
            var category = await Client_Application_Category.Include(x => x.Clients).ToListAsync();
            return category;
        }
        public async Task<Client_Application_Category> GetClientApplicationCategoryByID(int clientCategoryId)
        {
            var _qs = await Client_Application_Category
           .Where(x => x.Client_ID == clientCategoryId).Include(x => x.Clients).FirstOrDefaultAsync();
            return _qs;
        }
        public async Task<int> AddClientApplicationCategory(Client_Application_Category client_Application_Category)
        {
            var rec = new Client_Application_Category()
            {
                Client_ID = client_Application_Category.Client_ID,
                Application_ID = client_Application_Category.Application_ID,
                Client_Application_Category_Name = client_Application_Category.Client_Application_Category_Name,
                Client_Application_Category_Key = client_Application_Category.Client_Application_Category_Key,
                Client_Application_Category_Description = client_Application_Category.Client_Application_Category_Description,
                Status_ID = client_Application_Category.Status_ID,
                Status_Value = client_Application_Category.Status_Value,
                Created_By_ID = client_Application_Category.Created_By_ID,
                Created_By_Name = client_Application_Category.Created_By_Name,
                Created_Date = client_Application_Category.Created_Date,
                Updated_By_ID = client_Application_Category.Updated_By_ID,
                Updated_By_Name = client_Application_Category.Updated_By_Name,
                Updated_Date = client_Application_Category.Updated_Date
            };
            context.client_Application_Categories.Add(rec);
            await context.SaveChangesAsync();

            return client_Application_Category.Client_ID;
        }
        public async Task UpdateClientApplicationCategory(int clientApplicationCategoryId, Client_Application_Category client_Application_Category)
        {
            var ua = await context.client_Application_Categories.FindAsync(clientApplicationCategoryId);
            if (ua != null)
            {

                ua.Client_ID = client_Application_Category.Client_ID;
                ua.Application_ID = client_Application_Category.Application_ID;
                ua.Client_Application_Category_Name = client_Application_Category.Client_Application_Category_Name;
                ua.Client_Application_Category_Key = client_Application_Category.Client_Application_Category_Key;
                ua.Client_Application_Category_Description = client_Application_Category.Client_Application_Category_Description;
                ua.Status_ID = client_Application_Category.Status_ID;
                ua.Status_Value = client_Application_Category.Status_Value;
                ua.Created_By_ID = client_Application_Category.Created_By_ID;
                ua.Created_By_Name = client_Application_Category.Created_By_Name;
                ua.Created_Date = client_Application_Category.Created_Date;
                ua.Updated_By_ID = client_Application_Category.Updated_By_ID;
                ua.Updated_By_Name = client_Application_Category.Updated_By_Name;
                ua.Updated_Date = client_Application_Category.Updated_Date;

                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteClientApplicationCategory(int clientApplicationCategoryId)
        {
            var ca = new Client_Application_Category() { Client_Application_Category_ID = clientApplicationCategoryId };

            context.client_Application_Categories.Remove(ca);
            await context.SaveChangesAsync();
        }
    }
}
