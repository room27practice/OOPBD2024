using LeagueOfLegendsLibrary.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace LeagueOfLegendsLibrary.Services
{
    public interface IRepository<TEntity> : IDisposable
     where TEntity : DeletableEntity, new()
    {
        Task AddAssync(TEntity entity);
        Task AddRangeAssync(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        IQueryable<TEntity> All();
        Task<int> SaveChangesAsync();
    }

    public class DbRepository<TEntity> : IRepository<TEntity>
        where TEntity : DeletableEntity, new()
    {

        private ApplicationDbContext context;
        private DbSet<TEntity> dbSet;

        public DbRepository(ApplicationDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public async Task AddAssync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAssync(IEnumerable<TEntity> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IQueryable<TEntity> All()
        {
            return dbSet;
        }

        public void Remove(TEntity entity)
        {
            entity.Delete();
            //dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var item in entities)
            {
                item.Delete();
            }

            //  dbSet.RemoveRange(entities);
        }

        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }


}