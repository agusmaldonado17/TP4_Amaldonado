using System;
using System.Collections.Generic;
using System.Text;

namespace TP4_Amaldonado.Models
{
    public class CartRequest
    {
        public int UserId { get; set; }

        public List<CartRequestProduct> Products { get; set; } = new();
    }

    public class CartRequestProduct
    {
        public int Id { get; set; }

        public int Quantity { get; set; }
    }

}
