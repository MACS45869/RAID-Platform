using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Features
{
    public class Client_Features
    {
        [Key]
        public int Client_Feature_ID { get; set; }
        public int Application_Feature_Map_ID { get; set; }
        public int Client_ID { get; set; }
        public virtual Clients.Clients Client { get; set; }
    }
}
