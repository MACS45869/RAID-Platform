using System.ComponentModel.DataAnnotations;
namespace RAIDPlatform.Data.Models.Master.Navigation_Feature_Map
{
    public class Navigation_Feature_Map
    {
        [Key]
        public int Navigation_Feature_Map_ID { get; set; }
        public int Navigation_ID { get; set; }
        public int Feature_Permission_ID { get; set; }
        public virtual Navigations.Navigations Navigations { get; set; }
        public virtual Feature_Permissions.Feature_Permissions FeaturePermissions { get; set; }
    }
}
