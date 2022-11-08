﻿namespace RAIDPlatform.Data.Model.Client
{
    public class Client_Application_Security_Group
    {
        public int Client_Application_Security_Group_ID { get; set; }
        public int Client_ID { get; set; }
        public int Application_ID { get; set; }
        public string Client_Application_Security_Group_Name { get; set; }
        public string Client_Application_Security_Group_Key {get; set; }
        public string? Client_Application_Security_Group_Description { get; set; }
        public int Status_ID { get; set; }
        public string Status_Value { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
        public virtual Clients.Clients Client { get; set; }

    }
}
