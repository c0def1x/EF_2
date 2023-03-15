using System.ComponentModel.DataAnnotations;

namespace EF_Category_Product.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Product> Products { get; set; }

        public Category()
        {
            Id = Guid.NewGuid();
        }
    }
}
