using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public partial class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
        [Required (ErrorMessage = "Category Id is required")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
        public string? CategoryName { get; set; }
        [Required(ErrorMessage = "base price is required")]
        public decimal? BasePrice { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
