using RAIDPlatform.Data.Models.Master.Application_Data_Map;
using RAIDPlatform.Data.Models.Master.Application_Feature_Map;
using RAIDPlatform.Web.Api.DTO.MasterDTO;

namespace RAIDPlatform.Web.Api.Minimal
{
    public class MinimalApplicationDto
    {
        public int Id { get; set; }
        public string? Application_Name { get; set; }
        public string? Application_Key { get; set; }
        public string? Application_Description { get; set; }
        //  public byte? Application_Emblem { get; set; }
        //  public byte? Application_Logo { get; set; }
        public int Created_By_ID { get; set; }
        public string? Created_By_Name { get; set; }
        public DateTime? Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string? Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
        public virtual ICollection<Application_Data_Map_Dto> Application_Data_Map { get; set; }
    }
}
