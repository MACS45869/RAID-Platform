using RAIDPlatform.Data.Models.Master.Application_Data_Map;
using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Data
{
    public class Client_Data
    {
        [Key]
        public int Id { get; set; }
        public int ApplicationDataMapId { get; set; }
        public virtual Application_Data_Map ApplicationDataMap { get; set; }
        public int ClientId { get; set; }
        public virtual Clients.Clients Client {get;set;}
    }
}
