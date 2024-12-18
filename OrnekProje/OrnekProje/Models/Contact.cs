using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrnekProje.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Email adresi zorunludur!")]
        [EmailAddress]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string Message { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
    }
}
