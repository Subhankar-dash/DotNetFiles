using System;
using System.Collections.Generic;

namespace MySearchConsole.Models
{
    public partial class ProductDetail
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ManufracturerName { get; set; } = null!;
        public int Price { get; set; }
        public string Seller { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
