using RAIDPlatform.Data.Models.Master.Parameter_Values;
using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Users
{
    public class Users
    {
        [Key]
        public int User_ID { get; set; }
        public int Client_ID { get; set; }
        public virtual Clients.Clients? Client { get; set; }
        public int User_Type_ID { get; set; }
        public virtual Parameter_Values? User_Type { get; set; }
        public string User_Type_Value { get; set; }
        public bool Is_AD_User { get; set; }
        public string User_Email { get; set; }
        public string User_Name { get; set; }
        public string? Phone_Number { get; set; }
        public int Designation_ID { get; set; }
        public virtual Parameter_Values? Designation { get; set; }
        public string Designation_Value { get; set; }
        public int? Reporting_To_ID { get; set; }
        public virtual Parameter_Values? Reporting_To { get; set; }
        public string? Reporting_To_Name { get; set; }
        public int Org_Hierarchy_ID { get; set; }
        public virtual Parameter_Values? Org_Hierarchy { get; set; }
        public string Org_Hierarchy_Value { get; set; }
        public string User_Password { get; set; }
        public bool User_OTP { get; set; }
        public DateTime? User_OTP_Expiry { get; set; }
        public bool User_OTP_Expired { get; set; }
        public int Status_ID { get; set; }
        public virtual Parameter_Values? Status { get; set; }
        public string Status_Value { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
