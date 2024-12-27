using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency.Models.DTOs
{
    public class ClientsWithDestinationsForChartDto
    {
        public int ClientId { get; set; }
        public string ClientThreeNames { get; set; } = null!;
        public string ClientCountry { get; set; } = null!;
        public string Destination_Country { get; set; } = null!;
        public string Destination_City { get; set; } = null!;
    }
}
