using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Master.Application_Parameter_Map
{
    public class Application_Parameter_Map
    {
        [Key]
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public virtual Applications.Applications Application { get; set; }
        public int ParameterId { get; set; }
        public virtual Parameters Parameter { get; set; }
        public int ModuleId { get; set; }
        public virtual Modules.Modules Module { get; set; }
    }
}
