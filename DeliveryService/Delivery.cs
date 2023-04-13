namespace DeliveryService.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string CourierName { get; set; }
        public int OrderId { get; set; }
        public byte DeliveryStatus { get; set; }
        public DateTime DeliveryStatusChangeDate { get; set; }
    }


}
