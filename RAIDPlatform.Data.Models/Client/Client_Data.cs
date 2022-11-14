﻿using System.ComponentModel.DataAnnotations;

namespace RAIDPlatform.Data.Models.Client.Client_Data
{
    public class Client_Data
    {
        [Key]
        public int Client_Data_ID { get; set; }
        public int Application_Data_Map_ID { get; set; }
        public int Client_ID { get; set; }
        public virtual Clients.Clients Client {get;set;}
    }
}