using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public partial class Product
    {
        public int ProductUniqueId { get; set; }
        [Required(ErrorMessage = "Product Id is required")]
        public string ProductId { get; set; } = null!;
        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; } = null!;
        [Required(ErrorMessage = "Descrition is required")]
        public string Descrition { get; set; } = null!;
        [Required(ErrorMessage = "price is required")]
        public decimal Price { get; set; }
        public int SubCategoryId { get; set; }
        public int ManufractureId { get; set; }

        public virtual Manufracturer? Manufracture { get; set; } = null!;
        public virtual SubCategory? SubCategory { get; set; } = null!;
    }
}
