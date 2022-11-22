using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Master.Application_Data_Map
{
    public class Application_Data_Map
    {
        [Key]
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public virtual Applications.Applications Application { get; set; }
        public int DataPermissionId { get; set; }
        public virtual Data_Permissions.Data_Permissions DataPermissions { get; set; }
        public int ModuleId { get; set; }
        public virtual Modules.Modules Module { get; set; }

        }
}
