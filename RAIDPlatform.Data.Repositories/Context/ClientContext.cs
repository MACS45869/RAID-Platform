
using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Models.Client.Client_Application_Category_Data_Map;
using RAIDPlatform.Data.Models.Client.Users;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Repositories.Base;
using RAIDPlatform.Data.Models.Client.Client_Application_Category_Data_Values;
using RAIDPlatform.Data.Models.Client;
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
using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Parameter_Values;
using System.Reflection.Metadata;
using RAIDPlatform.Data.Models.Master;
using Microsoft.Extensions.Configuration;

namespace RAIDPlatform.Data.Repositories.Context
{
    public class ClientContext : BaseDbContext<ClientContext>
    {
        internal object client_Application_Security_Group;
        private readonly IConfiguration configuration;
        public DbSet<Client_Application_Category> client_Application_Categories { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Client_Application_Category_Data_Map> client_Application_Category_Data_Maps { get; set; }
        public DbSet<Client_Application_Category_Data_Values> client_Application_Category_Data_Values { get; set; }
        public DbSet<Client_Application_Security_Group> client_Application_Security_Groups{ get; set; }
        public DbSet<Client_Application_Security_Group_Category_Map> client_Application_Security_Group_Category_Map { get; set; } 
        public DbSet<Client_Application_Security_Group_Feature_Map> client_Application_Security_Group_Feature_Map{ get; set; }
        public DbSet<Client_Data> client_Data { get; set; }
        public DbSet<Client_Features> client_Feature { get; set; }
        public DbSet<Client_Module_Map> client_Module_Map { get; set; }
        public DbSet<Client_Navigation_Feature_Map> client_Navigation_Feature_Map { get; set; }
        public DbSet<Client_Navigations> client_Navigation { get; set; }
        public DbSet<Client_Parameter_Values> client_Parameter_Value { get; set; }
        public DbSet<Client_Parameters> client_Parameters { get; set; }
        public DbSet<Clients> clients { get; set; }
        public DbSet<User_Category_Map> user_Category_Map { get; set; }
        public DbSet<User_Security_Group_Map> user_Security_Group_Map{ get; set; }
        public DbSet<Parameter_Values> parameter_Values { get; set; }


        public ClientContext(DbContextOptions<ClientContext> options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConstructDatabaseModel(configuration);
            // modelBuilder.SeedNotificationKeys(configuration);
        }

    }
    }
