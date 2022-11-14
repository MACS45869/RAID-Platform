
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

namespace RAIDPlatform.Data.Repositories.Context
{
    public class ClientContext : BaseDbContext<ClientContext>
    {
        internal object client_Application_Security_Group;

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


        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client_Application_Category>(entity =>
            {
                entity.HasOne(x => x.Client).WithOne().HasForeignKey<Clients>(fk => fk.Client_ID);
                entity.HasOne(x => x.Application).WithOne().HasForeignKey<Applications>(fk => fk.Application_ID);
                entity.HasOne(x => x.Status).WithOne().HasForeignKey<Parameter_Values>(fk => fk.Parameter_Value_ID);
                entity.ToTable("Client_Application_Category");
            });
            modelBuilder.Entity<Parameter_Values>().ToTable("Parameter_Values")
                .HasOne(x => x.Parameter).WithOne().HasForeignKey<Parameters>(fk => fk.Parameter_ID);
                //.ToTable("Client_Application_Category")
                //.HasOne(x => x.Client)
                //.WithOne()
                //.HasForeignKey<Clients>(fk => fk.Client_ID);
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Client_Application_Category_Data_Map>().ToTable("Client_Application_Category_Data_Map");
            modelBuilder.Entity<Client_Application_Category_Data_Values>().ToTable("Client_Application_Category_Data_Values");
            modelBuilder.Entity<Client_Application_Security_Group>().ToTable("Client_Application_Security_Group");
            modelBuilder.Entity<Client_Application_Security_Group_Category_Map>().ToTable("Client_Application_Security_Group_Category_Map");
            modelBuilder.Entity<Client_Application_Security_Group_Feature_Map>().ToTable("Client_Application_Security_Group_Feature_Map");
            modelBuilder.Entity<Client_Data>().ToTable("Client_Data")
                .HasOne(x => x.Client).WithOne().HasForeignKey<Clients>(fk => fk.Client_ID);
            modelBuilder.Entity<Client_Features>().ToTable("Client_Features")
                .HasOne(x => x.Client)
                .WithOne()
                .HasForeignKey<Clients>(fk => fk.Client_ID);
            modelBuilder.Entity<Client_Module_Map>().ToTable("Client_Module_Map")
                .HasOne(x => x.Client)
                .WithOne()
                .HasForeignKey<Clients>(fk => fk.Client_ID);
            modelBuilder.Entity<Client_Navigation_Feature_Map>().ToTable("Client_Navigation_Feature_Map");
            modelBuilder.Entity<Client_Navigations>().ToTable("Client_Navigations")
                .HasOne(x => x.Client)
                .WithOne()
                .HasForeignKey<Clients>(fk => fk.Client_ID);
            modelBuilder.Entity<Client_Parameter_Values>().ToTable("Client_Parameter_Values");
            modelBuilder.Entity<Client_Parameters>().ToTable("Client_Parameters")
                .HasOne(x => x.Client)
                .WithOne()
                .HasForeignKey<Clients>(fk => fk.Client_ID);
            modelBuilder.Entity<Clients>().ToTable("Clients");
            modelBuilder.Entity<User_Category_Map>().ToTable("User_Category_Map")
                .HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<Users>(fk => fk.User_ID);
            modelBuilder.Entity<User_Security_Group_Map>().ToTable("User_Security_Group_Map")
                .HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<Users>(fk => fk.User_ID);


            base.OnModelCreating(modelBuilder);
        }

    }
    }
