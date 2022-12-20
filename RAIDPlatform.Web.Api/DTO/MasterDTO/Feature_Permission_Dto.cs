namespace RAIDPlatform.Web.Api.DTO.MasterDTO
{
    public class Feature_Permission_Dto
    {
        public int Id { get; set; }
        public string Feature_Permission_Name { get; set; }
        public string Feature_Permission_Key { get; set; }
        public string? Feature_Permission_Description { get; set; }
        public int Parent_ID { get; set; }
        public bool Is_Header { get; set; }
        public int Sequence_Number { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
