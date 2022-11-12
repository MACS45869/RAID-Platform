using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Model.Master.Application_Data_Map;
using RAIDPlatform.Data.Model.Master.Application_Feature_Map;
using RAIDPlatform.Data.Model.Master.Application_Module_Map;
using RAIDPlatform.Data.Model.Master.Application_Navigation_Map;
using RAIDPlatform.Data.Model.Master.Application_Parameter_Map;
using RAIDPlatform.Data.Model.Master.Applications;
using RAIDPlatform.Data.Model.Master.Data_Permissions;
using RAIDPlatform.Data.Model.Master.Feature_Permissions;
using RAIDPlatform.Data.Model.Master.Modules;
using RAIDPlatform.Data.Model.Master.Navigation_Feature_Map;
using RAIDPlatform.Data.Model.Master.Navigations;
using RAIDPlatform.Data.Model.Master.Parameter_Values;
using RAIDPlatform.Data.Model.Master;
using RAIDPlatform.Data.Repositories.Base;

namespace RAIDPlatform.Data.Repositories.Context
{
    public class MasterContext : BaseDbContext<MasterContext>
    {
        
       
            public DbSet<Application_Data_Map> application_Data_Maps { get; set; }
            public DbSet<Application_Feature_Map> application_Feature_Maps { get; set; }
            public DbSet<Application_Module_Map> application_Module_Maps { get; set; }
            public DbSet<Application_Navigation_Map> application_Navigation_Maps { get; set; }
            public DbSet<Application_Parameter_Map> application_Parameter_Maps { get; set; }
            public DbSet<Applications> applications { get; set; }
            public DbSet<Data_Permissions> data_Permissions { get; set; }
            public DbSet<Feature_Permissions> feature_Permissions { get; set; }
            public DbSet<Modules> modules { get; set; }
            public DbSet<Navigation_Feature_Map> navigation_Feature_Maps { get; set; }
            public DbSet<Navigations> navigations { get; set; }
            public DbSet<Parameter_Values> parameter_Values { get; set; }
            public DbSet<Parameters> parameters { get; set; }

        public MasterContext(DbContextOptions<MasterContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application_Data_Map>().ToTable("Application_Data_Map");
            modelBuilder.Entity<Application_Feature_Map>().ToTable("Application_Feature_Map");
            modelBuilder.Entity<Application_Module_Map>().ToTable("Application_Module_Map");
            modelBuilder.Entity<Application_Navigation_Map>().ToTable("Application_Navigation_Map");
            modelBuilder.Entity<Application_Parameter_Map>().ToTable("Application_Parameter_Map");
            modelBuilder.Entity<Applications>().ToTable("Applications");
            modelBuilder.Entity<Data_Permissions>().ToTable("Data_Permissions");
            modelBuilder.Entity<Feature_Permissions>().ToTable("Feature_Permissions");
            modelBuilder.Entity<Modules>().ToTable("Modules");
            modelBuilder.Entity<Navigation_Feature_Map>().ToTable("Navigation_Feature_Map");
            modelBuilder.Entity<Navigations>().ToTable("Navigations");
            modelBuilder.Entity<Parameter_Values>().ToTable("Parameter_Values");
            modelBuilder.Entity<Parameters>().ToTable("Parameters");
          

            base.OnModelCreating(modelBuilder);
        }
    }
}
