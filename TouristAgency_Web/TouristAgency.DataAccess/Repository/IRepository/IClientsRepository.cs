using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristAgency.Models;
using TouristAgency.Models.DTOs;

namespace TouristAgency.DataAccess.Repository.IRepository
{
    public interface IClientsRepository : IGenericRepository<Clients>
    {
        public Task<List<ClientWith_DestinationDTO>> GetClientsByDateRange(DateOnly startDate, DateOnly endDate);
        public Task<List<ClientsWithDestinationsForChartDto>> GetClientsWithDestinations();
    }
}
