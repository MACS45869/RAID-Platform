using System.ComponentModel.DataAnnotations;
namespace RAIDPlatform.Data.Models.Master.Navigation_Feature_Map
{
    public class Navigation_Feature_Map
    {
        [Key]
        public int Id { get; set; }
        public int NavigationId { get; set; }
        public virtual Navigations.Navigations Navigation { get; set; }
        public int FeaturePermissionId { get; set; }
        public virtual Feature_Permissions.Feature_Permissions FeaturePermission { get; set; }
    }
}
