namespace ShopOnline.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageUrl { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQty { get; set; }
        public int CategoryId { get; set; }
    }
}
