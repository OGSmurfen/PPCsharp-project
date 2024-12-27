using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency.Models.DTOs
{
    public class OrderWith_ClientExcursionDTO
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public string ClientThreeNames { get; set; } = null!;
        public int ClientEGN { get; set; }
        public DateOnly ClientInsuranceNumber { get; set; }
        public int ExcursionId { get; set; }
        public string ExcursionDestinationCountry { get; set; } = null!;
        public string ExcursionDestinationCity { get; set; } = null!;
        public DateOnly DateOrderCreated { get; set; }

    }
}
