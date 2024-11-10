using System.ComponentModel.DataAnnotations;

namespace BookStoreAdminApplication.Models
{
    public class Book
    {
        [Required]
        public string? isbn { get; set; }
        [Required]
        public string? title { get; set; }
        public string? description { get; set; }
        public string? imageURL { get; set; }
        [Required]
        public int totalPages { get; set; }
        [Required]
        public double? rating { get; set; }
        public double? price { get; set; }
    }
}
