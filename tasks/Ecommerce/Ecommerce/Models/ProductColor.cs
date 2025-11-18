namespace Ecommerce.Models
{
    public class ProductColor
    { 
        public int ProductId { get; set; }
        public string Color { get; set; }
        //navigation property
        public product Product { get; set; }
    }
}
