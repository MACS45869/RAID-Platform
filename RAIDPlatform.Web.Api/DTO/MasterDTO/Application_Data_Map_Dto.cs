using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Data_Permissions;
using RAIDPlatform.Data.Models.Master.Modules;

namespace RAIDPlatform.Web.Api.DTO.MasterDTO
{
    public class Application_Data_Map_Dto
    {
        public int Id { get; set; }
       // public int ApplicationId { get; set; }
     //   public virtual Applications.Applications Application { get; set; }
        public int DataPermissionId { get; set; }
        public virtual Data_Permissions DataPermission { get; set; }
        public int ModuleId { get; set; }
     //  public virtual Modules.Modules Module { get; set; }
    }
}
