namespace RAIDPlatform.Data.Model.Client.Client_Navigations
{
    public class Client_Navigations
    {
        public int Client_Navigation_ID { get; set; }
            public int Navigation_ID { get; set; }
            public int Client_ID { get; set; }
            public string Client_Navigation_Name { get; set; }    
            public string Client_Navigation_Key { get; set; }
            public string? Client_Navigation_Description { get; set; }
            public string? Client_Navigation_URL { get; set; }
            public int Parent_ID { get; set; }
            public bool Is_Menu { get; set; }
            public bool Is_Header { get; set; }
            public int Sequence_Number { get; set; }
            public int Created_By_ID { get; set; }
            public string Created_By_Name { get; set; }
            public DateTime Created_Date { get; set; }
            public int Updated_By_ID { get; set; }
            public string Updated_By_Name { get; set; }
            public DateTime Updated_Date { get; set; }
            public virtual Clients.Clients Client { get; set; }

    }
}
