using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TreinamentoJazzRaphael.EntityFramework.Repositories
{
    public abstract class TreinamentoJazzRaphaelRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TreinamentoJazzRaphaelDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TreinamentoJazzRaphaelRepositoryBase(IDbContextProvider<TreinamentoJazzRaphaelDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TreinamentoJazzRaphaelRepositoryBase<TEntity> : TreinamentoJazzRaphaelRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TreinamentoJazzRaphaelRepositoryBase(IDbContextProvider<TreinamentoJazzRaphaelDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
