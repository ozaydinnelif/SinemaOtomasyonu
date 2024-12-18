using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasitAlisVeris.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="bu alanın doldurulması zorunludur")]
        public string AdminName {  get; set; }
        [DisplayName("Şifre")]
        [Required(ErrorMessage = "bu alanın doldurulması zorunludur")]
        [MinLength(8,ErrorMessage ="sekiz karakterden uzun ollmalı ")]
        public string AdminPass { get; set; }
    }
}
