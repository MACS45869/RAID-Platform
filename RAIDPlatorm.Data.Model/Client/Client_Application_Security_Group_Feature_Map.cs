namespace RAIDPlateform.Data.Model.Client.Client_Application_Security_Group_Feature_Map
{
    public class Client_Application_Security_Group_Feature_Map
    {
        public int Client_Application_Security_Group_Feature_Map_ID { get; set; }
        public int Client_Application_Security_Group_ID { get; set; }
        public int Client_Feature_ID { get; set; }
        public virtual Client_Application_Security_Group ClientApplicationSecurityGroup { get; set; }
        public virtual Client_Features.Client_Features ClientFeatureID {get;set;}
    }
}
