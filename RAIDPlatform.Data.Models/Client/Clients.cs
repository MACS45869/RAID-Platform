using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Clients
{
    public class Clients
    {
        [Key]
        public int Client_ID { get; set; }
        public string Client_Name { get; set; }
        public string Client_Key { get; set; }
        public string? Client_Description { get; set; }
        public string? Primary_Address { get; set; }
        public string? Primary_Email { get; set; }
        public string? Primary_Landline { get; set; }
        public string? Primary_Cell { get; set; }
        public string Primary_Contact_Name { get; set; }
        public string Primary_Contact_Email { get; set; }
        public string? Primary_Contact_Landline { get; set; }
        public string? Primary_Contact_Cell { get; set; }
        public string? Secondary_Contact_Name { get; set; }
        public string? Secondary_Contact_Email { get; set; }
        public string? Secondary_Contact_Landline { get; set; }
        public string? Secondary_Contact_Cell { get; set; }
        public int Status_ID { get; set; }
        public string Status_Value { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }

       
    }
}
