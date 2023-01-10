using RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Category_Map;
using RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Feature_Map;
using RAIDPlatform.Data.Models.Client.Clients;
using RAIDPlatform.Data.Models.Client.User_Security_Group_Map;
using RAIDPlatform.Data.Models.Master.Applications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAIDPlatform.Web.Api.DTO.ClientDTO
{
    public class Client_Application_Security_Group_Dto
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public virtual Applications Application { get; set; }
        public string Client_Application_Security_Group_Name { get; set; }
        public string Client_Application_Security_Group_Key { get; set; }
        public string? Client_Application_Security_Group_Description { get; set; }
        public int StatusId { get; set; }
        public string Status_Value { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int? Updated_By_ID { get; set; }
        public string? Updated_By_Name { get; set; }
        public DateTime? Updated_Date { get; set; }
        public int ClientId { get; set; }

        public virtual ICollection<User_Security_Group_Map_Dto> Users { get; set; }
        public virtual ICollection<Client_Application_Security_Group_Category_Map_Dto> Categories { get; set; }
        public virtual ICollection<Client_Application_Security_Group_Feature_Map_Dto> Features { get; set; }
    }
}
