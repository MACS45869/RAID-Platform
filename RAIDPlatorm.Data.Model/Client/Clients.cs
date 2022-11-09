﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RAIDPlatform.Data.Model.Client.Clients
{
    public class Clients : BaseEntity
    {
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

        [NotMapped]
        public int CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [NotMapped]
        public int? UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [NotMapped]
        public DateTime CreatedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [NotMapped]
        public DateTime? UpdatedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [NotMapped]
        public bool Active { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
