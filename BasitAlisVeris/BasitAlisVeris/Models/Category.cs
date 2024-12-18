using System.ComponentModel.DataAnnotations;

namespace BasitAlisVeris.Models
{
    public class Category
    {
        [Key]
        public int Id {  get; set; }
        public string Category_Name { get; set; } = string.Empty;
        public virtual ICollection<SubCategory>? SubCategories { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

    }
}
