using System.ComponentModel.DataAnnotations;

namespace EF_Category_Product.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Category Category { get; set; }
        
        public decimal PriceWithDiscount()
        {
            return Price - Discount;
        }

        public Product()
        {
            Id = Guid.NewGuid();
        }

    }
}
