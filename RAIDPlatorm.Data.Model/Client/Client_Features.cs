﻿namespace RAIDPlateform.Data.Model.Client.Client_Features
{
    public class Client_Features
    {
        public int Client_Feature_ID { get; set; }
        public int Application_Feature_Map_ID { get; set; }
        public int Client_ID { get; set; }
        public virtual Clients.Clients Client { get; set; }
    }
}
