namespace Ecommerce.Models
{
    public class ProductSubImage
    { public int ProductId { get; set; }
        //navigation property
        public product Product { get; set; }
        public string Img { get; set; }
    }
}
