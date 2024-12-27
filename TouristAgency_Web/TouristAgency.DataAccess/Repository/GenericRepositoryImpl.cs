using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TouristAgency.DataAccess.Data;
using TouristAgency.DataAccess.Repository.IRepository;

namespace TouristAgency.DataAccess.Repository
{
    public class GenericRepositoryImpl<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly TouristAgencyDbContext dbContext;
        private readonly DbSet<TEntity> dbSet;
        public GenericRepositoryImpl(TouristAgencyDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public async Task CreateAsync(TEntity e)
        {
            await dbSet.AddAsync(e);
            //await dbContext.SaveChangesAsync();
        }

        public void Delete(TEntity e)
        {
            dbSet.Remove(e);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null, bool tracked = true)
        {
            IQueryable<TEntity> query = dbSet;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>>? filter = null, bool tracked = true)
        {
            IQueryable<TEntity> query = dbSet;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public void Update(TEntity e)
        {
            dbSet.Update(e);
        }
    }
}
