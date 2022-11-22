using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Application_Category_Data_Values
{
    public class Client_Application_Category_Data_Values
    {
        [Key]
        public int Id { get; set; }
        public int ClientApplicationCategoryDataMapId { get; set; }
        public virtual Client_Application_Category_Data_Map.Client_Application_Category_Data_Map ClientApplicationCategoryDataMap { get; set; }
        public int Client_Application_Data_Value_ID { get; set; }
        public string Client_Application_Data_Value_Text { get; set; }
        public string Client_Application_Data_Value_Key { get; set; }
    }
}
