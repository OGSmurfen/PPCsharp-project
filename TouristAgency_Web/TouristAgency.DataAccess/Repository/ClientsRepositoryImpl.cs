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
    public class ClientsRepositoryImpl : GenericRepositoryImpl<Clients>, IClientsRepository
    {
        private readonly TouristAgencyDbContext _dbContext;
        public ClientsRepositoryImpl(TouristAgencyDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }



        public async Task<List<ClientWith_DestinationDTO>> GetClientsByDateRange(DateOnly startDate, DateOnly endDate)
        {
            return await (from order in _dbContext.Orders
                          join client in _dbContext.Clients on order.ClientId equals client.ClientId
                          join excursion in _dbContext.Excursions on order.ExcursionId equals excursion.ExcursionId
                          where order.DateIssued >= startDate && order.DateIssued <= endDate
                          select new ClientWith_DestinationDTO
                          {
                              ClientId = order.ClientId,
                              ThreeNames = client.ThreeNames,
                              EGN = client.EGN,
                              Destination_City = excursion.Destination_City,
                              Destination_Country = excursion.Destination_Country,
                              DateOrderIssued = order.DateIssued,
                          }).ToListAsync();
        }

        public async Task<List<ClientsWithDestinationsForChartDto>> GetClientsWithDestinations()
        {
            return await (from order in _dbContext.Orders
                          join client in _dbContext.Clients on order.ClientId equals client.ClientId
                          join excursion in _dbContext.Excursions on order.ExcursionId equals excursion.ExcursionId
                          select new ClientsWithDestinationsForChartDto
                          {
                              ClientId = order.ClientId,
                              ClientCountry = client.Country,
                              ClientThreeNames = client.ThreeNames,
                              Destination_City = excursion.Destination_City,
                              Destination_Country= excursion.Destination_Country,
                          }
                          ).ToListAsync();

        }


    }
}
