using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency.Models.DTOs
{
    public class ClientWith_DestinationDTO
    {
        public int ClientId { get; set; }
        public int EGN { get; set; }
        public string ThreeNames { get; set; } = null!;
        public string Destination_Country { get; set; } = null!;
        public string Destination_City { get; set; } = null!;
        public DateOnly DateOrderIssued { get; set; }
    }
}
