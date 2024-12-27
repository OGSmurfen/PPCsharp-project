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
    public class OrdersRepositoryImpl : GenericRepositoryImpl<Orders>, IOrdersRepository
    {
        private readonly TouristAgencyDbContext _dbContext;
        public OrdersRepositoryImpl(TouristAgencyDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<OrderWith_ClientExcursionDTO>> GetOrdersWithClientsExcursionsAsync()
        {
            return await (from order in _dbContext.Orders
                          join client in _dbContext.Clients on order.ClientId equals client.ClientId
                          join excursion in _dbContext.Excursions on order.ExcursionId equals excursion.ExcursionId
                          select new OrderWith_ClientExcursionDTO
                          {
                              OrderId = order.OrderId,
                              ClientId = order.ClientId,
                              ClientThreeNames = client.ThreeNames,
                              ClientEGN = client.EGN,
                              ClientInsuranceNumber = client.InsuranceNumber,
                              ExcursionId = order.ExcursionId,
                              ExcursionDestinationCity = excursion.Destination_City,
                              ExcursionDestinationCountry = excursion.Destination_Country,
                              DateOrderCreated = order.DateIssued 
                          })
                 .ToListAsync();
        }

    }
}
