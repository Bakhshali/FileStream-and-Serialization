using System;
using System.Collections.Generic;
using System.Text;

namespace FileStream_and_Serialization_Practice.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public double TotalPrice { get; set; }

    }
}
