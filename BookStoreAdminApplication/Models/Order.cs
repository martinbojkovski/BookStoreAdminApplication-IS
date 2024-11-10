namespace BookStoreAdminApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string ownerId { get; set; }
        public BookStoreUser owner { get; set; }
        public IEnumerable<BookInOrder> bookInOrders { get; set; }
    }
}
