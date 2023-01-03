using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Feature_Permissions;
using RAIDPlatform.Data.Models.Master.Modules;

namespace RAIDPlatform.Web.Api.DTO.MasterDTO
{
    public class Application_Feature_Map_Dto
    {
        public int Id { get; set; } 
        public int FeaturePermissionId { get; set; }
        public virtual Feature_Permissions FeaturePermission { get; set; }

        public int? ModuleId { get; set; }
        public virtual Modules Modules { get; set; }
    }
}
