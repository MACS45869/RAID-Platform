﻿namespace RAIDPlatform.Data.Model.Master.Parameter_Values
{
    public class Parameter_Values
    {
        public int Parameter_Value_ID { get; set; }
        public int Parameter_ID { get; set; }
        public string Parameter_Value_Name { get; set; }
        public string Parameter_Value_Key { get; set; }
        public string? Parameter_Value_Description { get; set; }
        public int Parent_ID { get; set; }
        public bool Is_Header { get; set; }
        public int Parameter_Value_Type { get; set; }
        public string Parameter_Value_Text { get; set; }
        public float Parameter_Value_Numeric { get; set; }
        public DateTime Parameter_Value_Date { get; set; }
        public bool Parameter_Value_Boolean { get; set; }
        public byte Parameter_Value_Image { get; set; }
        public virtual Parameters.Parameters Parameters { get; set; }
    }
}
