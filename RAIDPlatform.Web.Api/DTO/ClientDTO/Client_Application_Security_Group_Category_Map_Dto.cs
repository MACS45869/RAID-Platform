using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client;

namespace RAIDPlatform.Web.Api.DTO.ClientDTO
{
    public class Client_Application_Security_Group_Category_Map_Dto
    {
        public int Id { get; set; }
        public virtual Client_Application_Category_Dto ClientApplicationCategory { get; set; }
    }
}
