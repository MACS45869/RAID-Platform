﻿using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Category_Map
{
    public class Client_Application_Security_Group_Category_Map
    {
        [Key]
        public int Client_Application_Security_Group_Category_Map_ID { get; set; }
        public int Client_Application_Security_Group_ID { get; set; }
        public int Client_Application_Category_ID { get; set; }
        public virtual Client_Application_Security_Group ClientApplicationSecurityGroup { get; set; }
        public virtual Client_Application_Category.Client_Application_Category ClientApplicationCategory { get; set; }
    }
}