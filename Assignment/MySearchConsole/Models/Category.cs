﻿using System;
using System.Collections.Generic;

namespace MySearchConsole.Models
{
    public partial class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public decimal? BasePrice { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
