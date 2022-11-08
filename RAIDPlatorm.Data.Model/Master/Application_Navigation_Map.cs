namespace RAIDPlateform.Data.Model.Master.Application_Navigation_Map
{
    public class Application_Navigation_Map
    {
        public int Application_Navigation_Map_ID { get; set; }
        public int Application_ID { get; set; }
        public int Navigation_ID { get; set; }
        public int Module_ID { get; set; }
        public virtual Applications.Applications Applications { get; set; }
        public virtual Navigations.Navigations Navigations { get; set; }
        public virtual Modules.Modules Modules { get; set; }
    }
}
