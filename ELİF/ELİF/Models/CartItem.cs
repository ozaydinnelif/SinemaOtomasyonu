using Microsoft.AspNetCore.Mvc;

namespace ELİF.Models
{
    public class CartItem
    {
        public int Id { get; set; } // Her bir sepet öğesi için benzersiz bir kimlik
        public int ProductId { get; set; } // Sepetteki ürünün kimliği
        public Product Product { get; set; } // İlgili ürün
        public int Quantity { get; set; } // Sepetteki ürünün adedi
        public string CartId { get; set; } // Sepetin kimliği (kullanıcıya özel)
    }
}
