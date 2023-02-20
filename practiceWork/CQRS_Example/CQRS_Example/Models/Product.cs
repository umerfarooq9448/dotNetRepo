using System;
using System.Collections.Generic;

namespace CQRS_Example.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductPrice { get; set; }
    }
}
