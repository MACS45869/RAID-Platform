using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Parameters
{
    public class Client_Parameters
    {
        [Key]
        public int Id { get; set; }
        public int ParameterId { get; set; }
        public int ClientId { get; set; }
        public virtual Clients.Clients Client { get; set; }
        public string Client_Parameter_Name { get; set; }
        public string Client_Parameter_Key { get; set; }
        public string Client_Parameter_Description { get; set; }
        public string Client_Parameter_Type { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
