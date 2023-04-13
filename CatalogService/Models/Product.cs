using System.Data.SqlTypes;

namespace CatalogService.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public SqlMoney ProductPrice { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}