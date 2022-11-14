using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Parameter_Values
{
    public class Client_Parameter_Values
    {
        [Key]
        public int Client_Parameter_Value_ID { get; set; }
        public int Client_Parameter_ID { get; set; }
        public string Client_Parameter_Value_Name { get; set; }
        public string Client_Parameter_Value_Key { get; set; }
        public string? Client_Parameter_Value_Description { get; set; }
        public int Parent_ID { get; set; }
        public bool Is_Header { get; set; }
        public int Client_Parameter_Value_Type { get; set; }
        public string? Client_Parameter_Value_Text { get; set; }
        public float? Client_Parameter_Value_Numeric { get; set; }
        public DateTime Client_Parameter_Value_Date { get; set; }
        public bool? Client_Parameter_Value_Boolean { get; set; }
        public byte[]? Client_Parameter_Value_Image { get; set; }
        public int Status_ID { get; set; }
        public string Status_Value { get; set; }
        public int Created_By_ID { get; set; }
        public string Created_By_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By_ID { get; set; }
        public string Updated_By_Name { get; set; }
        public DateTime Updated_Date { get; set; }
        public virtual Client_Parameters.Client_Parameters ClientParameter { get; set; }
    }
}
