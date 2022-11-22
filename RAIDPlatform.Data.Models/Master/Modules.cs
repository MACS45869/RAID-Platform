using System.ComponentModel.DataAnnotations;
namespace RAIDPlatform.Data.Models.Master.Modules
{
    public class Modules
    {
        [Key]
        public int Id { get; set; }
        public string Modules_Name { get; set; }
        public string Modules_Key { get; set; }
        public string? Modules_Description { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
