using System;
using System.Collections.Generic;

namespace NorthWindApi1.Models
{
    public partial class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; } = null!;
    }
}
