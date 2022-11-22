using System.ComponentModel.DataAnnotations;
namespace RAIDPlatform.Data.Models.Master
{
    public class Parameters
    {
        [Key]
        public int Id { get; set; }
        public string Parameter_Name { get; set; }
        public string Parameter_Key { get; set; }
        public string Parameter_Description { get; set; }
        public string Parameter_Type { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
