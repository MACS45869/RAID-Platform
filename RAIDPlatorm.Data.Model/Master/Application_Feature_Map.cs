namespace RAIDPlateform.Data.Model.Master.Application_Feature_Map
{
    public class Application_Feature_Map
    {
        public int Application_Feature_Map_ID { get; set; }
        public int Application_ID { get; set; }
        public int Feature_Permission_ID { get; set; }
        public int Module_ID { get; set; }

        public virtual Modules.Modules Modules { get; set; }
        public virtual Feature_Permissions.Feature_Permissions FeaturePermissions { get; set; }
        public virtual Applications.Applications Applications { get; set; }
    }
}
