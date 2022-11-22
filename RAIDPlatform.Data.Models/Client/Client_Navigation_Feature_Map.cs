using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Navigation_Feature_Map
{
    public class Client_Navigation_Feature_Map
    {
        [Key]
        public int Id { get; set; }
        public int ClientNavigationId { get; set; }
        public virtual Client_Navigations.Client_Navigations ClientNavigation { get; set; }
        public int ClientFeatureId { get; set; }
        public virtual Client_Features.Client_Features ClientFeature { get; set; }
    }
}
