using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristAgency.Models;
using TouristAgency.Models.DTOs;

namespace TouristAgency.DataAccess.Repository.IRepository
{
    public interface IOrdersRepository : IGenericRepository<Orders>
    {
        public Task<List<OrderWith_ClientExcursionDTO>> GetOrdersWithClientsExcursionsAsync();
    }
}
