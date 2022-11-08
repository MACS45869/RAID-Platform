namespace RAIDPlatform.Data.Model.Client.Client_Navigation_Feature_Map
{
    public class Client_Navigation_Feature_Map
    {
        public int Client_Navigation_Feature_Map_ID { get; set; }
        public int Client_Navigation_ID { get; set; }
        public int Client_Feature_ID { get; set; }
        public virtual Client_Navigations.Client_Navigations ClientNavigation { get; set; }
        public virtual Client_Features.Client_Features ClientFeature { get; set; }
    }
}
