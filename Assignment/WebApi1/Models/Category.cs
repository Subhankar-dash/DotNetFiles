using System;
using System.Collections.Generic;
using WebApi1.CustomOps.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi1.Models
{
    public partial class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
        //[Required(ErrorMessage = "Category Id is Raquired")]
        public int CategoryId { get; set; }
        //[Required(ErrorMessage = "Category Name is Raquired")]
        public string? CategoryName { get; set; }
        //[Required(ErrorMessage = "Base Price is Raquired")]
        //[NumericNoNegtive(ErrorMessage = "Base Price Can not be -ve")]
        public decimal? BasePrice { get; set; }

        public virtual ICollection<SubCategory?> SubCategories { get; set; }
    }






    //public partial class Category
    //    {
    //        public Category()
    //        {
    //            Products = new HashSet<Product>();
    //        }
    //        [Required(ErrorMessage = "Category Id is Raquired")]
    //        public int CategoryId { get; set; }
    //        [Required(ErrorMessage = "Category Name is Raquired")]
    //        public string CategoryName { get; set; } = null!;
    //        [Required(ErrorMessage = "Base Price is Raquired")]
    //        [NumericNoNegtive(ErrorMessage = "Base Price Can not be -ve")]
    //        public decimal BasePrice { get; set; }

    //        public virtual ICollection<Product> Products { get; set; }
    //    }
    //}




}
