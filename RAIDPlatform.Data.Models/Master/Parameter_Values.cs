using RAIDPlatform.Data.Models.Client.Users;
using System.ComponentModel.DataAnnotations;
namespace RAIDPlatform.Data.Models.Master.Parameter_Values
{
    public class Parameter_Values
    {
        [Key]
        public int Parameter_Value_ID { get; set; }
        public string Parameter_Value_Name { get; set; }
        public string Parameter_Value_Key { get; set; }
        public string? Parameter_Value_Description { get; set; }
        public int Parent_ID { get; set; }
        public bool Is_Header { get; set; }
        public int Parameter_Value_Type { get; set; }
        public string Parameter_Value_Text { get; set; }
        public decimal Parameter_Value_Numeric { get; set; }
        public DateTime Parameter_Value_Date { get; set; }
        public bool Parameter_Value_Boolean { get; set; }
        public byte Parameter_Value_Image { get; set; }
        public int Parameter_ID { get; set; }
        public virtual Parameters Parameter { get; set; }

        public virtual ICollection<Users> User_Types { get; set; }
        public virtual ICollection<Users> Designations { get; set; }
        public virtual ICollection<Users> Reporting_Tos { get; set; }
        public virtual ICollection<Users> Org_Hierarchies { get; set; }
        public virtual ICollection<Users> Statuses { get; set; }
    }
}
