using KenticoCloud.Delivery;

namespace DancingGoatGcp
{
    public class ProjectOptions
    {
        public DeliveryOptions DeliveryOptions { get; set; }
        public int CacheTimeoutSeconds { get; set; }
    }
}
