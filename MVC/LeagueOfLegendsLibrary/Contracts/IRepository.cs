namespace LeagueOfLegendsLibrary.Contracts
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


}