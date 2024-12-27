using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency.DataAccess.Repository.IRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null, bool tracked = true);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>>? filter = null, bool tracked = true);
        Task CreateAsync(TEntity e);
        void Update(TEntity e);
        void Delete(TEntity e);
    }
}
