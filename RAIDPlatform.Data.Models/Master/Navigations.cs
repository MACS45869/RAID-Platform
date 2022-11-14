using System.ComponentModel.DataAnnotations;
namespace RAIDPlatform.Data.Models.Master.Navigations
{
    public class Navigations
    {
        [Key]
        public int Navigation_ID { get; set; }
        public string Navigation_Name { get; set; }
        public string Navigation_Key { get; set; }
        public string? Navigation_Description { get; set; }
        public string? Navigation_URL { get; set; }
        public int Parent_ID { get; set; }
        public bool Is_Header { get; set; }
        public bool Is_Menu { get; set; }
        public int Sequence_Number { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
