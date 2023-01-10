using RAIDPlatform.Data.Models.Client.Client_Features;
using RAIDPlatform.Data.Models.Client;

namespace RAIDPlatform.Web.Api.DTO.ClientDTO
{
    public class Client_Application_Security_Group_Feature_Map_Dto
    {
        public int Id { get; set; }
        public virtual Client_Features_Dto ClientFeature { get; set; }
    }
}
