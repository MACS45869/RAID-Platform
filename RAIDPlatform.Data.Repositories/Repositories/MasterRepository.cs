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
using RAIDPlatform.Data.Model.Master.Parameters;
using RAIDPlatform.Data.Repositories.Base;
using RAIDPlatform.Data.Repositories.Context;
using RAIDPlatform.Data.Repositories.Interfaces;

namespace RAIDPlatform.Data.Repositories.Repositories
{
    public class MasterRepository : BaseRepository<Applications, MasterContext>, IClientRepository
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


        public MasterRepository(IUnitOfWork<MasterContext> uow) : base(uow)
        {
            var context = (MasterContext)uow.Context;
            Application_Data_Map = context.application_Data_Maps;
            Application_Feature_Map = context.application_Feature_Maps;
            Application_Module_Map = context.application_Module_Maps
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
    }
}
