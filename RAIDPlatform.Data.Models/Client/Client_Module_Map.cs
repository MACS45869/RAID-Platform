using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Modules;
using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Module_Map
{
    public class Client_Module_Map
    {
        [Key]
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public virtual Modules Module { get; set; }
        public int ClientId { get; set; }
        public virtual Clients.Clients Client { get; set; }
        public int ApplicationId { get; set; }
    }
}
