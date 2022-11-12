using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Model.Master.Application_Parameter_Map
{
    public class Application_Parameter_Map
    {
        [Key]
        public int Application_Parameter_Map_ID { get; set; }
        public int Application_ID { get; set; }
        public int Parameter_ID { get; set; }
        public int Module_ID { get; set; }
        public virtual Applications.Applications Applications { get; set; }
        public virtual Parameters Parameters { get; set; }
        public virtual Modules.Modules Modules { get; set; }
    }
}
