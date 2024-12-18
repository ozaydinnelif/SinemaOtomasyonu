using Microsoft.AspNetCore.Mvc;
using ELİF.Services;

namespace ELİF.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService;

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            var cartItems = _cartService.GetCartItems();
            return View(cartItems); // Sepet öğelerini görüntülemek için Index sayfasına yönlendir
        }

        public IActionResult AddToCart(int id)
        {
            _cartService.AddToCart(id); // Ürünü sepete ekle
            return RedirectToAction("Index"); // Sepet sayfasına yönlendir
        }

        public IActionResult RemoveFromCart(int id)
        {
            _cartService.RemoveFromCart(id); // Ürünü sepetten çıkar
            return RedirectToAction("Index"); // Sepet sayfasına yönlendir
        }
    }
}
