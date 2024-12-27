using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey(nameof(ExcursionId))]
        public int ExcursionId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public int ClientId { get; set; }
        public DateOnly DateIssued { get; set; }

    }
}
