using RAIDPlatform.Data.Models.Master.Application_Feature_Map;

namespace RAIDPlatform.Web.Api.DTO.MasterDTO
{
    public class Applications_Dto
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
        public virtual ICollection<Application_Feature_Map_Dto> Application_Feature_Map { get; set; }

    }
}
