using System;
using System.Collections.Generic;
using System.Text;

namespace FileStream_and_Serialization_Practice.Models
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public Computers Computer { get; set; }
        public double Price { get; set; }

    }
}
