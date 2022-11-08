namespace RAIDPlateform.Data.Model.Client.User_Security_Group_Map
{
    public class User_Security_Group_Map
    {
        public int User_Security_Group_Map_ID { get; set; }
        public int User_ID { get; set; }
        public int Client_Application_Security_Group_ID { get; set; }
        public virtual Users.Users User { get; set; }
        public virtual Client_Application_Security_Group ClientApplicationSecurityGroupID { get; set; } 
    }
}
