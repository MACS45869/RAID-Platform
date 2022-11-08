
using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Model.Client.Client_Application_Category_Data_Map;
using RAIDPlatform.Data.Model.Client.Users;
using RAIDPlatform.Data.Model.Client.Client_Application_Category;
using RAIDPlatform.Data.Repositories.Base;
using RAIDPlatform.Data.Model.Client.Client_Application_Category_Data_Values;
using RAIDPlatform.Data.Model.Client;
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

namespace RAIDPlatform.Data.Repositories.Context
{
    public class ClientContext : BaseDbContext<ClientContext>
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options) { }

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client_Application_Category>().ToTable("Client_Application_Category");
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Client_Application_Category_Data_Map>().ToTable("Client_Application_Category_Data_Map");
            modelBuilder.Entity<Client_Application_Category_Data_Values>().ToTable("Client_Application_Category_Data_Values");
            modelBuilder.Entity<Client_Application_Security_Group>().ToTable("Client_Application_Security_Group");
            modelBuilder.Entity<Client_Application_Security_Group_Category_Map>().ToTable("Client_Application_Security_Group_Category_Map");
            modelBuilder.Entity<Client_Application_Security_Group_Feature_Map>().ToTable("Client_Application_Security_Group_Feature_Map");
            modelBuilder.Entity<Client_Data>().ToTable("Client_Data");
            modelBuilder.Entity<Client_Module_Map>().ToTable("Client_Module_Map");
            modelBuilder.Entity<Client_Navigation_Feature_Map>().ToTable("Client_Navigation_Feature_Map");
            modelBuilder.Entity<Client_Navigations>().ToTable("Client_Navigations");
            modelBuilder.Entity<Client_Parameter_Values>().ToTable("Client_Parameter_Values");
            modelBuilder.Entity<Client_Parameters>().ToTable("Client_Parameters");
            modelBuilder.Entity<Clients>().ToTable("Clients");
            modelBuilder.Entity<User_Category_Map>().ToTable("User_Category_Map");
            modelBuilder.Entity<User_Security_Group_Map>().ToTable("User_Security_Group_Map");


            base.OnModelCreating(modelBuilder);
        }

    }
    }
