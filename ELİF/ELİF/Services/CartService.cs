using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ELİF.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using ELİF.Data;

namespace ELİF.Services
{

    public class CartService
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetCartId()
        {
            var cartId = _httpContextAccessor.HttpContext.Session.GetString("CartId");
            if (cartId == null)
            {
                cartId = Guid.NewGuid().ToString();
                _httpContextAccessor.HttpContext.Session.SetString("CartId", cartId);
            }
            return cartId;
        }

        public void AddToCart(int productId)
        {
            var cartId = GetCartId();
            var cartItem = _context.CartItems.SingleOrDefault(c => c.CartId == cartId && c.ProductId == productId);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    ProductId = productId,
                    CartId = cartId,
                    Quantity = 1
                };
                _context.CartItems.Add(cartItem); // Doğru kullanım: DbSet üzerinden Add
            }
            else
            {
                cartItem.Quantity++;
            }
            _context.SaveChanges();
        }

        public void RemoveFromCart(int productId)
        {
            var cartId = GetCartId();
            var cartItem = _context.CartItems.SingleOrDefault(c => c.CartId == cartId && c.ProductId == productId);

            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem); // Doğru kullanım: DbSet üzerinden Remove
                _context.SaveChanges();
            }
        }

        public List<CartItem> GetCartItems()
        {
            var cartId = GetCartId();
            return _context.CartItems.Include(c => c.Product).Where(c => c.CartId == cartId).ToList();
        }
    }
}
