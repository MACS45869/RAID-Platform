using AutoMapper.Configuration.Annotations;
using RAIDPlatform.Data.Models.Master.Application_Feature_Map;
using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Feature_Permissions;
using RAIDPlatform.Data.Models.Master.Parameter_Values;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAIDPlatform.Data.Models.Client
{
    public class Client_Application_Security_Group
    {
        [Key]
        public int Id { get; set; }
        public int ApplicationId { get; set; }
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

        //[NotMapped]
        public int ClientId { get; set; }
        public virtual Clients.Clients Client { get; set; }
        
        public virtual Applications Application { get; set; }
        public virtual Application_Feature_Map Application_Feature_Map { get; set; }
        public virtual Feature_Permissions Feature_Permission { get; set; }


    }
}
