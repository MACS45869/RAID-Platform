﻿using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Parameter_Values;
using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Application_Category
{
    public class Client_Application_Category
    {
        [Key]
        public int Client_Application_Category_ID { get; set; }
        public string Client_Application_Category_Name { get; set; }
        public string Client_Application_Category_Key { get; set; }
        public string Client_Application_Category_Description { get; set; }
        public int Application_ID { get; set; }
        public virtual Applications Application { get; set; }
        public int Status_ID { get; set; }
        public virtual Parameter_Values Status { get; set; }
        public string Status_Value { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }

        //[NotMapped]
        public int Client_ID { get; set; }
        public virtual Clients.Clients Client { get; set; }
    }
}
