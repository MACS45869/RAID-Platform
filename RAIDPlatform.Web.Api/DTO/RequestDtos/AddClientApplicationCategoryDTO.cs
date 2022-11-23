﻿namespace RAIDPlatform.Web.Api.DTO
{
    public class AddClientApplicationCategoryDTO
    {
        public int Client_Application_Category_ID { get; set; }
        public string Client_Application_Category_Name { get; set; }
        public string Client_Application_Category_Key { get; set; }
        public string Client_Application_Category_Description { get; set; }
        public int Application_ID { get; set; }
        public int StatusId { get; set; }
        public string Status_Value { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
        public int Client_ID { get; set; }
    }
}
