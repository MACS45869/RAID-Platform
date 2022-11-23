using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Feature_Map
{
    public class Client_Application_Security_Group_Feature_Map
    {
        [Key]
        public int Id { get; set; }
        public int ClientApplicationSecurityGroupId { get; set; }
        public virtual Client_Application_Security_Group ClientApplicationSecurityGroup { get; set; }
        public int ClientFeatureId { get; set; }
        public virtual Client_Features.Client_Features ClientFeature {get;set;}
    }
}
