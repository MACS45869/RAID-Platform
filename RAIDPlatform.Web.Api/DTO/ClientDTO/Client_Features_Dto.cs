using RAIDPlatform.Data.Models.Client.Clients;
using RAIDPlatform.Data.Models.Master.Application_Feature_Map;

namespace RAIDPlatform.Web.Api.DTO.ClientDTO
{
    public class Client_Features_Dto
    {
        public int Id { get; set; }
        public int ApplicationFeatureMapId { get; set; }
        public virtual Application_Feature_Map ApplicationFeatureMap { get; set; }
        public int ClientId { get; set; }
        public virtual Clients_Dto Client { get; set; }
    }
}
