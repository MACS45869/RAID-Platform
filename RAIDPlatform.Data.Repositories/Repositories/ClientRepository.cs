using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Models.Client;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Client_Application_Category_Data_Map;
using RAIDPlatform.Data.Models.Client.Client_Application_Category_Data_Values;
using RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Category_Map;
using RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Feature_Map;
using RAIDPlatform.Data.Models.Client.Client_Data;
using RAIDPlatform.Data.Models.Client.Client_Features;
using RAIDPlatform.Data.Models.Client.Client_Module_Map;
using RAIDPlatform.Data.Models.Client.Client_Navigation_Feature_Map;
using RAIDPlatform.Data.Models.Client.Client_Navigations;
using RAIDPlatform.Data.Models.Client.Client_Parameter_Values;
using RAIDPlatform.Data.Models.Client.Client_Parameters;
using RAIDPlatform.Data.Models.Client.Clients;
using RAIDPlatform.Data.Models.Client.User_Category_Map;
using RAIDPlatform.Data.Models.Client.User_Security_Group_Map;
using RAIDPlatform.Data.Models.Client.Users;
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
        public async Task<List<Clients>> GetAllClient()
        {
            var clients = await Clients.ToListAsync();
            return clients;
        }
        public async Task<Clients> GetClientsByID(int clientId)
        {
            var _qs = await Clients

               .Where(x => x.Id == clientId).FirstOrDefaultAsync();

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
                StatusId = clients.StatusId,
                Status_Value = clients.Status_Value,
                Created_By_ID = clients.Created_By_ID,
                Created_By_Name = clients.Created_By_Name,
                Created_Date = clients.Created_Date,
                Updated_By_ID = clients.Updated_By_ID,
                Updated_By_Name = clients.Updated_By_Name,
                Updated_Date = clients.Updated_Date
            };
            context.clients.Add(rec);
            var saved = await context.SaveChangesAsync();

            return saved;
        }
        public async Task<int> UpdateClients(Clients clients)
        {
            Clients.Update(clients);
            await context.SaveChangesAsync();
            return clients.Id;
        }
        public async Task<bool> DeleteClients(int clientId)
        {
            var qs = Clients.Where(x => x.Id == clientId).FirstOrDefault();
            if (qs != null)
            {
                Clients.Remove(qs);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Client_Application_Category>> GetAllClientApplicationCategory()
        {
            var category = await Client_Application_Category
                .Include(x => x.Client)
                .ToListAsync();
            return category;
        }
        public async Task<Client_Application_Category> GetClientApplicationCategoryById(int clientCategoryId)
        {
            var _qs = await Client_Application_Category
                .Include(x => x.Client)
                .Where(x => x.Id == clientCategoryId)
                .FirstOrDefaultAsync();
            return _qs;
        }

        public async Task<List<Client_Application_Category>> GetAllClientApplicationCategoryByApplicationId(int appID)
        {
            var _qs = await Client_Application_Category
            .Where(x => x.ApplicationId == appID)
            .ToListAsync();
            return _qs;

        }
        public async Task<List<Client_Application_Category>> GetAllClientApplicationCategoryByClientId(int clientID)
        {
            var _qs = await Client_Application_Category

                .Include(x => x.Client)
                .Where(x => x.ClientId == clientID).ToListAsync();

            return _qs;
        }

        public async Task<int> AddClientApplicationCategory(Client_Application_Category client_Application_Category)
        {
            var rec = new Client_Application_Category()
            {
                ClientId = client_Application_Category.ClientId,
                ApplicationId = client_Application_Category.ApplicationId,
                Client_Application_Category_Name = client_Application_Category.Client_Application_Category_Name,
                Client_Application_Category_Key = client_Application_Category.Client_Application_Category_Key,
                Client_Application_Category_Description = client_Application_Category.Client_Application_Category_Description,
                StatusId = client_Application_Category.StatusId,
                Status_Value = client_Application_Category.Status_Value,
                Created_By_ID = client_Application_Category.Created_By_ID,
                Created_By_Name = client_Application_Category.Created_By_Name,
                Created_Date = client_Application_Category.Created_Date,
                Updated_By_ID = client_Application_Category.Updated_By_ID,
                Updated_By_Name = client_Application_Category.Updated_By_Name,
                Updated_Date = client_Application_Category.Updated_Date
            };
            context.client_Application_Categories.Add(rec);
            var saved = await context.SaveChangesAsync();

            return saved;
        }
        public async Task<int> UpdateClientApplicationCategory(Client_Application_Category client_Application_Category)
        {
            Client_Application_Category.Update(client_Application_Category);
            await context.SaveChangesAsync();
            return client_Application_Category.Id;
        }
        public async Task<bool> DeleteClientApplicationCategory(int clientApplicationCategoryId)
        {
            var qs = Client_Application_Category.Where(x => x.Id == clientApplicationCategoryId).FirstOrDefault();
            if (qs != null)
            {
                Client_Application_Category.Remove(qs);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<List<Client_Application_Security_Group>> GetAllClientApplicationSecurityGroup()
        {
            var sg = await Client_Application_Security_Group
                .Include(x => x.Application)
                .Include(x => x.Client)
                .ToListAsync();
            return sg;
        }
        public async Task<List<Client_Application_Security_Group>> GetAllClientApplicationSecurityGroupByClientId(int clientID)
        {
            var _qs = await Client_Application_Security_Group

                .Include(x => x.Client)
                .Include(x => x.Application)
                .ThenInclude(x => x.Application_Feature_Map)
                .ThenInclude(x => x.FeaturePermission)
                .Where(x => x.ClientId == clientID)
                .ToListAsync();

            return _qs;
        }
        public async Task<Client_Application_Security_Group> GetClientApplicationSecurityGroupById(int clientApplicationSecurityGroupId)
        {
            var _qs = await Client_Application_Security_Group
                .Include(x => x.Client)
                .Include(x => x.Application)
                .ThenInclude(x => x.Application_Feature_Map)
                .ThenInclude(x => x.FeaturePermission)
                .Where(x => x.Id == clientApplicationSecurityGroupId)
                .FirstOrDefaultAsync();
            return _qs;
        }
        public async Task<int> AddClientApplicationSecurityGroup(Client_Application_Security_Group client_Application_Security_Group)
        {
            var rec = new Client_Application_Security_Group()
            {
                ClientId = client_Application_Security_Group.ClientId,
                ApplicationId = client_Application_Security_Group.ApplicationId,
                Client_Application_Security_Group_Name = client_Application_Security_Group.Client_Application_Security_Group_Name,
                Client_Application_Security_Group_Key = client_Application_Security_Group.Client_Application_Security_Group_Key,
                Client_Application_Security_Group_Description = client_Application_Security_Group.Client_Application_Security_Group_Description,
                StatusId = client_Application_Security_Group.StatusId,
                Status_Value = client_Application_Security_Group.Status_Value,
                Created_By_ID = client_Application_Security_Group.Created_By_ID,
                Created_By_Name = client_Application_Security_Group.Created_By_Name,
                Created_Date = client_Application_Security_Group.Created_Date,
                Updated_By_ID = client_Application_Security_Group.Updated_By_ID,
                Updated_By_Name = client_Application_Security_Group.Updated_By_Name,
                Updated_Date = client_Application_Security_Group.Updated_Date
            };

            Client_Application_Security_Group.Add(rec);
            var saved = await context.SaveChangesAsync();
            return saved;
        }
        public async Task<int> UpdateClientApplicationSecurityGroup(Client_Application_Security_Group client_Application_Security_Group)
        {
            Client_Application_Security_Group.Update(client_Application_Security_Group);
            await context.SaveChangesAsync();
            return client_Application_Security_Group.Id;
        }
        public async Task<bool> DeleteClientApplicationSecurityGroup(int clientApplicationSecurityGroupId)
        {
            var qs = Client_Application_Security_Group.Where(x => x.Id == clientApplicationSecurityGroupId).FirstOrDefault();
            if (qs != null)
            {
                Client_Application_Security_Group.Remove(qs);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Users>> GetAllUsers()
        {
            var users = await Users
                .ToListAsync();
            return users;
        }
        public async Task<Users> GetUsersByID(int userId)
        {
            var _us = await Users
                .Where(x => x.Id == userId)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            return _us;
        }
        public async Task<List<Users>> GetAllUserByClientId(int clientID)
        {
            var _qs = await Users
                .Include(x => x.Client)
                .Where(x => x.ClientId == clientID).ToListAsync();

            return _qs;
        }
        public async Task<List<Users>> GetAllUsersByApplicationId(int appID)
        {
            var users = await Users
                .ToListAsync();
            return users;
        }
        public async Task<int> AddUser(Users users)
        {
            var rec = new Users()
            {
                ClientId = users.ClientId,
                UserTypeId = users.UserTypeId,
                User_Type_Value = users.User_Type_Value,
                Is_AD_User = users.Is_AD_User,
                User_Email = users.User_Email,
                User_Name = users.User_Name,
                Phone_Number = users.Phone_Number,
                DesignationId = users.DesignationId,
                Designation_Value = users.Designation_Value,
                ReportingToId = users.ReportingToId,
                Reporting_To_Name = users.Reporting_To_Name,
                OrgHierarchyId = users.OrgHierarchyId,
                Org_Hierarchy_Value = users.Org_Hierarchy_Value,
                User_Password = users.User_Password,
                User_OTP = users.User_OTP,
                User_OTP_Expiry = users.User_OTP_Expiry,
                User_OTP_Expired = users.User_OTP_Expired,
                StatusId = users.StatusId,
                Status_Value = users.Status_Value,
                Created_By_ID = users.Created_By_ID,
                Created_By_Name = users.Created_By_Name,
                Created_Date = users.Created_Date,
                Updated_By_ID = users.Updated_By_ID,
                Updated_By_Name = users.Updated_By_Name,
                Updated_Date = users.Updated_Date

            };
            context.Users.Add(rec);
            var saved = await context.SaveChangesAsync();

            return saved;
        }
        public async Task<int> UpdateUsers(Users users)
        {
            Users.Update(users);
            await context.SaveChangesAsync();
            return users.Id;
        }
        public async Task<bool> DeleteUsers(int userId)
        {
            var qs = Users.Where(x => x.Id == userId).FirstOrDefault();
            if (qs != null)
            {
                Users.Remove(qs);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
        //public async Task<List<Client_Application_Security_Group>> GetAllClientApplicationSecurityGroupFeaturePermissions()
        //{
        //    var sg = await Client_Application_Security_Group
        //        .Include(x => x.Client)
        //        .Include(x => x.Application)
        //        .Include(x => x.Application_Feature_Map)
        //        .Include(x => x.Feature_Permission)
        //        .ToListAsync();
        //    return sg;
        //}
        //public async Task<Client_Application_Security_Group> GetClientApplicationSecurityGroupFeaturePermissionsById(int clientApplicationSecurityGroupId)
        //{
        //    var _qs = await Client_Application_Security_Group
        //        .Include(xx => xx.Client)
        //        .Include(xx => xx.Application)
        //        .Include(xx => xx.Application_Feature_Map)
        //        .Include(xx => xx.Feature_Permission)
        //        .Where(xx => xx.Id == clientApplicationSecurityGroupId)
        //        .FirstOrDefaultAsync();
        //    return _qs;
        //}
    }
}


