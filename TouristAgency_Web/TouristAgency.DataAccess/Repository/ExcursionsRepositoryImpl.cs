using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristAgency.DataAccess.Data;
using TouristAgency.DataAccess.Repository.IRepository;
using TouristAgency.Models;
using TouristAgency.Models.DTOs;

namespace TouristAgency.DataAccess.Repository
{
    public class ExcursionsRepositoryImpl : GenericRepositoryImpl<Excursions>, IExcursionsRepository
    {
        private readonly TouristAgencyDbContext _dbContext;
        public ExcursionsRepositoryImpl(TouristAgencyDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }




        public async Task<List<DestinationLookupDto>> DestinationsWithClientAndPrices(string ClientThreeNames)
        {
            return await (from order in  _dbContext.Orders
                          join client in _dbContext.Clients on order.ClientId equals client.ClientId
                          join excursion in _dbContext.Excursions on order.ExcursionId equals excursion.ExcursionId
                          where client.ThreeNames.Contains(ClientThreeNames)
                          select new DestinationLookupDto
                          {
                              ClientNames = client.ThreeNames,
                              Destination_City = excursion.Destination_City,
                              Destination_Country = excursion.Destination_Country,
                              Price_Transport = excursion.Price_Transport,
                              Price_Excursion = excursion.Price_Excursion,
                              Price_Additional = excursion.Price_Additional,
                              InsuranceNumber = client.InsuranceNumber,
                          }).ToListAsync();
        }

    }
}
