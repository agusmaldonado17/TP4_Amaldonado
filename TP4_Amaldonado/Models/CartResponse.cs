using System;
using System.Collections.Generic;
using System.Text;

namespace TP4_Amaldonado.Models
{
    public class CartResponse
    {
        public List<Cart> Carts { get; set; } = new();

        public int Total { get; set; }

        public int Skip { get; set; }

        public int Limit { get; set; }
    }
}
