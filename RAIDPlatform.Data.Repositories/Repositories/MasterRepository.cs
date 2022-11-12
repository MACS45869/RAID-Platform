using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Model.Client.Users;
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
using RAIDPlatform.Data.Repositories.Context;
using RAIDPlatform.Data.Repositories.Interfaces;
using System.Net;
using static System.Reflection.Metadata.BlobBuilder;

namespace RAIDPlatform.Data.Repositories.Repositories
{
    public class MasterRepository :  IMasterRepository
    {
        private DbSet<Application_Data_Map> Application_Data_Map;
        private DbSet<Application_Feature_Map> Application_Feature_Map;
        private DbSet<Application_Module_Map> Application_Module_Map;
        private DbSet<Application_Navigation_Map> Application_Navigation_Map;
        private DbSet<Application_Parameter_Map> Application_Parameter_Map;
        private DbSet<Applications> Applications;
        private DbSet<Data_Permissions> Data_Permissions;
        private DbSet<Feature_Permissions> Feature_Permissions;
        private DbSet<Modules> Modules;
        private DbSet<Navigation_Feature_Map> Navigation_Feature_Map;
        private DbSet<Navigations> Navigations;
        private DbSet<Parameter_Values> Parameter_Values;
        private DbSet<Parameters> Parameters;

        private readonly MasterContext context;

        public MasterRepository(MasterContext context) 
        {
            this.context = context;
            Application_Data_Map = context.application_Data_Maps;
            Application_Feature_Map = context.application_Feature_Maps;
            Application_Module_Map = context.application_Module_Maps;
            Application_Navigation_Map = context.application_Navigation_Maps;
            Application_Parameter_Map = context.application_Parameter_Maps;
            Applications = context.applications;
            Data_Permissions = context.data_Permissions;
            Feature_Permissions = context.feature_Permissions;
            Modules = context.modules;
            Navigation_Feature_Map = context.navigation_Feature_Maps;
            Navigations = context.navigations;
            Parameter_Values = context.parameter_Values;
            Parameters = context.parameters;
        }
        public async Task<List<Applications>> GetAllApplications()
        {
            var apps = await Applications.ToListAsync();
            return apps;
        }

        public async Task<Applications> GetApplicationByID(int appId)
        {
            var _qs = await Applications

               .Where(x => x.Application_ID == appId).FirstOrDefaultAsync();

            return _qs;
        }
        public async Task<int> AddApplicationAsync(Applications app)
        {
            var rec = new Applications()
            {
                Application_Name = app.Application_Name,
                Application_Key = app.Application_Key,
                Application_Description = app.Application_Description,
              //  Application_Emblem = app.Application_Emblem,
              //  Application_Logo = app.Application_Logo,
                Created_By_ID = app.Created_By_ID,
                Created_By_Name =app.Created_By_Name,
                Created_Date =app.Created_Date,
                Updated_By_ID =app.Updated_By_ID,
                Updated_By_Name =app.Updated_By_Name,
                Updated_Date =app.Updated_Date
            };
            context.applications.Add(rec);
            await context.SaveChangesAsync();

            return app.Application_ID;
        }
        public async Task UpdateApplication(int appId, Applications app)
        {
            var ua = await context.applications.FindAsync(appId);
            if (ua != null)
            {
                ua.Application_Name = app.Application_Name;
                ua.Application_Key = app.Application_Key;
                ua.Application_Description = app.Application_Description;
                //  Application_Emblem = app.Application_Emblem,
                //  Application_Logo = app.Application_Logo,
                ua.Created_By_ID = app.Created_By_ID;
                ua.Created_By_Name = app.Created_By_Name;
                ua.Created_Date = app.Created_Date;
                ua.Updated_By_ID = app.Updated_By_ID;
                ua.Updated_By_Name = app.Updated_By_Name;
                ua.Updated_Date = app.Updated_Date;
              
                await context.SaveChangesAsync();
            }  
        }
        public async Task DeleteApplication(int appId)
        {
            var app = new Applications() { Application_ID = appId };

            context.applications.Remove(app);
            await context.SaveChangesAsync();
        }
    }
}
