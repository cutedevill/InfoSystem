namespace OrderService.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAdress { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }
    }
}
