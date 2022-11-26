namespace RAIDPlatform.Web.Api.DTO.RequestDtos
{
    public class UpdateClientApplicationSecurityGroupDTO
    {
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
        public int ClientId { get; set; }
    }
}
