using RAIDPlatform.Data.Model.Master.Modules;
using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Model.Client.Client_Module_Map
{
    public class Client_Module_Map
    {
        [Key]
        public int Client_Module_Map_ID { get; set; }
        public int Module_ID { get; set; }
        public int Client_ID { get; set; }
        public int Application_ID { get; set; }
        public virtual Clients.Clients Client { get; set; }
        public virtual Modules Module { get; set; }
    }
}
