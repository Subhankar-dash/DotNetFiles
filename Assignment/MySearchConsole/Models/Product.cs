using System;
using System.Collections.Generic;

namespace MySearchConsole.Models
{
    public partial class Product
    {
        public int ProductUniqueId { get; set; }
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string Descrition { get; set; } = null!;
        public decimal Price { get; set; }
        public int SubCategoryId { get; set; }
        public int ManufractureId { get; set; }

        public virtual Manufracturer Manufracture { get; set; } = null!;
        public virtual SubCategory SubCategory { get; set; } = null!;
    }
}
