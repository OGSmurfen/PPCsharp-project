using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency.Models
{
    public class Excursions
    {
        [Key] 
        public int ExcursionId { get; set; }

        public string Destination_Country { get; set; } = null!;
        public string Destination_City { get; set; } = null!;
        public DateOnly BeginDate { get; set; }
        public DateOnly EndDate { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price_Transport { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price_Excursion { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Price_Additional { get; set; }


        public string DisplayName => $"Id_{ExcursionId}: {Destination_Country}, {Destination_City}";

    }
}
