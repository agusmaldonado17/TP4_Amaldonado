using System;
using System.Collections.Generic;
using System.Text;

namespace TP4_Amaldonado.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public List<CartProduct> Products { get; set; } = new();

        public decimal Total { get; set; }

        public decimal DiscountedTotal { get; set; }

        public int UserId { get; set; }

        public int TotalProducts { get; set; }

        public int TotalQuantity { get; set; }
    }
}
