using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst.Model
{
    /// <summary>
    /// Base Type with General Attributes
    /// </summary>
    public abstract class ProductionUnit
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(700)]
        public int ReleaseYear { get; set; }
    }

    public class Movies : ProductionUnit
    {
        public string Category { get; set; }
        public int PlayDuration { get; set; }
        public double BoxOfficeCollection { get; set; }
    }

    public class WebSeries : ProductionUnit
    {
        public int Seasons { get; set; }
        public int EpisodPerSeason { get; set; }
    }
}