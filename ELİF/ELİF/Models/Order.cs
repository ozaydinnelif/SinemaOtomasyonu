﻿namespace ELİF.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
