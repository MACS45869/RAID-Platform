namespace RAIDPlateform.Data.Model.Master.Application_Data_Map
{
    public class Application_Data_Map
    {
        public int Application_Data_Map_ID { get; set; }
        public int Application_ID { get; set; }
        public int Data_Permission_ID { get; set; }
        public int Module_ID { get; set; }
        public virtual Applications.Applications Application { get; set; }
        public virtual Data_Permissions.Data_Permissions DataPermissions {get; set;}
        public virtual Modules.Modules Module { get; set; }
    }
}
