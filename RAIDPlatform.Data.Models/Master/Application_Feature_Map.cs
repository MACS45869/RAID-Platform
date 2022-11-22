using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Master.Application_Feature_Map
{
    public class Application_Feature_Map
    {
        [Key]
        public int Id { get; set; }

        public int ApplicationId { get; set; }
        public virtual Applications.Applications Applications { get; set; }

        public int FeaturePermissionId { get; set; }
        public virtual Feature_Permissions.Feature_Permissions FeaturePermissions { get; set; }

        public int ModuleId { get; set; }
        public virtual Modules.Modules Modules { get; set; }
    }
}
