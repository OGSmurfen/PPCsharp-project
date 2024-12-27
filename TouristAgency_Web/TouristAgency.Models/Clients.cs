using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }
        public int EGN { get; set; }
        public string ThreeNames { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateOnly BirthDate { get; set; }
        public DateOnly InsuranceNumber { get;set; }

        public string DisplayName => $"Id{ClientId}:{ThreeNames},EGN:{EGN}";
    }
}
