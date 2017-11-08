using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TaiKang.EntityFramework.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class TaiKangRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TaiKangDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TaiKangRepositoryBase(IDbContextProvider<TaiKangDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="TaiKangRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class TaiKangRepositoryBase<TEntity> : TaiKangRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TaiKangRepositoryBase(IDbContextProvider<TaiKangDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)!!!
    }
}
