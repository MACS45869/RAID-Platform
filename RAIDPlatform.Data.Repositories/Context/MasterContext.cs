using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Models.Master.Application_Data_Map;
using RAIDPlatform.Data.Models.Master.Application_Feature_Map;
using RAIDPlatform.Data.Models.Master.Application_Module_Map;
using RAIDPlatform.Data.Models.Master.Application_Navigation_Map;
using RAIDPlatform.Data.Models.Master.Application_Parameter_Map;
using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Data_Permissions;
using RAIDPlatform.Data.Models.Master.Feature_Permissions;
using RAIDPlatform.Data.Models.Master.Modules;
using RAIDPlatform.Data.Models.Master.Navigation_Feature_Map;
using RAIDPlatform.Data.Models.Master.Navigations;
using RAIDPlatform.Data.Models.Master.Parameter_Values;
using RAIDPlatform.Data.Models.Master;
using RAIDPlatform.Data.Repositories.Base;
using Microsoft.Extensions.Configuration;

namespace RAIDPlatform.Data.Repositories.Context
{
    public class MasterContext : BaseDbContext<MasterContext>
    {

        internal object client_Application_Security_Group;
        private readonly IConfiguration configuration;

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

        public MasterContext(DbContextOptions<MasterContext> options, IConfiguration configuration) : base(options) {

            this.configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConstructDatabaseModel(configuration);
        }
    }
}
