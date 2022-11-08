namespace RAIDPlateform.Data.Model.Client.Client_Parameters
{
    public class Client_Parameters
    {
        public int Client_Parameter_ID { get; set; }
        public int Parameter_ID { get; set; }
        public int Client_ID { get; set; }
        public string Client_Parameter_Name { get; set; }
        public string Client_Parameter_Key { get; set; }
        public string Client_Parameter_Description { get; set; }
        public string Client_Parameter_Type { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
        public virtual Clients.Clients Client { get; set; }
    }
}
