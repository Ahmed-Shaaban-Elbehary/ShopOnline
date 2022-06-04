namespace ShopOnline.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int CartItemQty { get; set; } //How Many Item Should Be Within The Cart.
    }
}
