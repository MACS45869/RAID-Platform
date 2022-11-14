﻿using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Application_Category_Data_Map
{
    public class Client_Application_Category_Data_Map
    {
        [Key]
        public int Client_Application_Category_Data_Map_ID { get; set; }
        public int Client_Application_Category_ID { get; set; }
        public int Client_Data_ID { get; set; }
        public virtual Client_Application_Category.Client_Application_Category ClientApplicationCategory { get; set; }
        public virtual Client_Data.Client_Data ClientData { get; set; }
    }
}