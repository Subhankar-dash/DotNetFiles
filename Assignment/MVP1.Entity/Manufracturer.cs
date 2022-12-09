using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Manufracturer
    {
        public Manufracturer()
        {
            Products = new HashSet<Product>();
        }

        public int ManufractureId { get; set; }
        public string ManufractureName { get; set; } = null!;
        public string ManufractureAdderess { get; set; } = null!;
        public string ManufractureCity { get; set; } = null!;
        public string ManufractureState { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
