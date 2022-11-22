using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Application_Category_Data_Map
{
    public class Client_Application_Category_Data_Map
    {
        [Key]
        public int Id { get; set; }
        public int ClientApplicationCategoryId { get; set; }
        public virtual Client_Application_Category.Client_Application_Category ClientApplicationCategory { get; set; }
        public int ClientDataId { get; set; }
        public virtual Client_Data.Client_Data ClientData { get; set; }
    }
}
