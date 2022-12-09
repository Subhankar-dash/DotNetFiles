using System;
using System.Collections.Generic;

namespace WebApi1.Models
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

        public virtual Manufracturer? Manufracturer { get; set; }
        public virtual SubCategory? SubCategory { get; set; }


        //}



        //public int ProductUniqueId { get; set; }
        //public string ProductId { get; set; } = null!;
        //public string ProductName { get; set; } = null!;
        //public string Description { get; set; } = null!;
        //public decimal Price { get; set; }
        //public int CategoryId { get; set; }
        //public string Manufacturer { get; set; } = null!;
        //// The Nullable Reference TYpe (C# 9.0+)    
        //public virtual Category? Category { get; set; }

    }
}
