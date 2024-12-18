using System.ComponentModel.DataAnnotations;

namespace BasitAlisVeris.Models
{
    public class SubCategory
    {
        [Key] 
        public int Id {  get; set; }
        public string SubCategory_Name { get; set; } = string.Empty;
        public int Category_Id { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Product>? Products { get; set;}
    }
}
