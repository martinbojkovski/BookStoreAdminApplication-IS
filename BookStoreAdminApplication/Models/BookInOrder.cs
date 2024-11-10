namespace BookStoreAdminApplication.Models
{
    public class BookInOrder
    {
        public Guid bookId { get; set; }
        public Book? orderedBook { get; set; }
        public Guid orderId { get; set; }
        public Order? order { get; set; }
        public int quantity { get; set; }
    }
}
