using RAIDPlatform.Data.Models.Client.Clients;

namespace RAIDPlatform.Web.Api.DTO.RequestDtos
{
    public class AddUsersDTO
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UserTypeId { get; set; }
        public string EmployeeNo { get; set; }
        public string User_Type_Value { get; set; }
        public bool Is_AD_User { get; set; }
        public string User_Email { get; set; }
        public string User_Name { get; set; }
        public string? Phone_Number { get; set; }
        public int DesignationId { get; set; }
        public string Designation_Value { get; set; }
        public int? ReportingToId { get; set; }
        public string? Reporting_To_Name { get; set; }
        public int OrgHierarchyId { get; set; }
        public string Org_Hierarchy_Value { get; set; }
        public string User_Password { get; set; }
        public bool User_OTP { get; set; }
        public DateTime? User_OTP_Expiry { get; set; }
        public bool User_OTP_Expired { get; set; }
        public int StatusId { get; set; }
        public string Status_Value { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
