using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.User_Category_Map
{
    public class User_Category_Map
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual Users.Users User { get; set; }
        public int ClientApplicationCategoryId { get; set; }
        public virtual Client_Application_Category.Client_Application_Category ClientApplicationCategory { get; set; }
        public int UserSecurityGroupMapId { get; set; }
        public virtual User_Security_Group_Map.User_Security_Group_Map UserSecurityGroupMap { get; set; }
    }
}
