using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency.Models.DTOs
{
    public class DestinationLookupDto
    {
        public string ClientNames { get; set; } = null!;
        public string Destination_Country { get; set; } = null!;
        public string Destination_City { get; set; } = null!;
        public decimal Price_Transport { get; set; }
        public decimal Price_Excursion { get; set; }
        public decimal? Price_Additional { get; set; }
        public DateOnly InsuranceNumber { get; set; }
    }
}
