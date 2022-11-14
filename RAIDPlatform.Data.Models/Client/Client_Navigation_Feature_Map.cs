using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Navigation_Feature_Map
{
    public class Client_Navigation_Feature_Map
    {
        [Key]
        public int Client_Navigation_Feature_Map_ID { get; set; }
        public int Client_Navigation_ID { get; set; }
        public int Client_Feature_ID { get; set; }
        public virtual Client_Navigations.Client_Navigations ClientNavigation { get; set; }
        public virtual Client_Features.Client_Features ClientFeature { get; set; }
    }
}
