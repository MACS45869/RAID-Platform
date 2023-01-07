using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAIDPlatform.Data.Models.Client.User_Security_Group_Map
{
    public class User_Security_Group_Map
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual Users.Users User { get; set; }
        public int ClientApplicationSecurityGroupId { get; set; }
        public virtual Client_Application_Security_Group ClientApplicationSecurityGroup { get; set; }
        

    }
}
