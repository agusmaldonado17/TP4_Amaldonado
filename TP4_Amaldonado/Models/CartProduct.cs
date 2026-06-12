using System;
using System.Collections.Generic;
using System.Text;

namespace TP4_Amaldonado.Models
{
    public class CartProduct
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }

        public decimal DiscountPercentage { get; set; }

        public decimal DiscountedTotal { get; set; }

        public string Thumbnail { get; set; } = string.Empty;
    }

}
