using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Pro.EntityFramework.Repositories
{
    public abstract class ProRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ProDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ProRepositoryBase(IDbContextProvider<ProDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ProRepositoryBase<TEntity> : ProRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ProRepositoryBase(IDbContextProvider<ProDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
