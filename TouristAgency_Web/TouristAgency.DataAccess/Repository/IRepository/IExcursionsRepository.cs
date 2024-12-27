using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristAgency.Models;
using TouristAgency.Models.DTOs;

namespace TouristAgency.DataAccess.Repository.IRepository
{
    public interface IExcursionsRepository : IGenericRepository<Excursions>
    {
        public Task<List<DestinationLookupDto>> DestinationsWithClientAndPrices(string ClientThreeNames);
    }
}
