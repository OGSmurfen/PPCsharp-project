using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristAgency.DataAccess.Data;
using TouristAgency.DataAccess.Repository.IRepository;

namespace TouristAgency.DataAccess.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TouristAgencyDbContext _dbContext;
        public IClientsRepository Clients {  get; }

        public IExcursionsRepository Excursions { get; }

        public IOrdersRepository Orders { get; }

        public UnitOfWork(
            TouristAgencyDbContext dbContext,
            IOrdersRepository ordersRepository,
            IExcursionsRepository excursionsRepository,
            IClientsRepository clientsRepository
            )
        {
            _dbContext = dbContext;
            Clients = clientsRepository;
            Excursions = excursionsRepository;
            Orders = ordersRepository;
        }

        public async Task SaveAsync()
        {
           await _dbContext.SaveChangesAsync();
        }
    }
}
