using RAIDPlatform.Data.Models.Client.Users;
using RAIDPlatform.Data.Models.Client;
using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Web.Api.DTO.ClientDTO
{
    public class User_Security_Group_Map_Dto
    {
        public int Id { get; set; }
        public virtual Users_Dto User { get; set; }
    }
}
