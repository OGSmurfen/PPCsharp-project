using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristAgency.DataAccess.Repository.IRepository;

namespace TouristAgency.DataAccess.UOW
{
    public interface IUnitOfWork
    {
        IClientsRepository Clients { get; }
        IExcursionsRepository Excursions { get; }
        IOrdersRepository Orders { get; }
        Task SaveAsync();
    }
}
