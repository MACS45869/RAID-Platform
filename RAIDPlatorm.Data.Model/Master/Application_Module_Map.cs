namespace RAIDPlatform.Data.Model.Master.Application_Module_Map
{
    public class Application_Module_Map
    {
        public int Application_Module_Map_ID { get; set; }
        public int Application_ID { get; set; }
        public int Module_ID { get; set; }

        public virtual Applications.Applications Applications { get; set; }
        public virtual Modules.Modules Modules { get; set; }
    }
}
