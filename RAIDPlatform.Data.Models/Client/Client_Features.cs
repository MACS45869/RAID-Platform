using RAIDPlatform.Data.Models.Master.Application_Feature_Map;
using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Features
{
    public class Client_Features
    {
        [Key]
        public int Id { get; set; }
        public int ApplicationFeatureMapId { get; set; }
        public virtual Application_Feature_Map ApplicationFeatureMap { get; set; }
        public int ClientId { get; set; }
        public virtual Clients.Clients Client { get; set; }
    }
}
