using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Master.Application_Navigation_Map
{
    public class Application_Navigation_Map
    {
        [Key]
        public int Id { get; set; }

        public int ApplicationId { get; set; }
        public virtual Applications.Applications Application { get; set; }
        
        public int NavigationId { get; set; }
        public virtual Navigations.Navigations Navigation { get; set; }

        public int ModuleId { get; set; }
        public virtual Modules.Modules Module { get; set; }
    }
}
