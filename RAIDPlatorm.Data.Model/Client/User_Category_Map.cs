using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Model.Client.User_Category_Map
{
    public class User_Category_Map
    {
        [Key]
        public int User_Category_Map_ID { get; set; }
        public int User_ID { get; set; }
        public int Client_Application_Category_ID { get; set; }
        public int User_Security_Group_Map_ID { get; set; }
        public virtual Users.Users User { get; set; }
        public virtual Client_Application_Category.Client_Application_Category ClientApplicationCategory { get; set; }
        public virtual User_Security_Group_Map.User_Security_Group_Map UserSecurityGroupMap { get; set; }
    }
}
