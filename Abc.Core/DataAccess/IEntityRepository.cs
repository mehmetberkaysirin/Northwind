using Abc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Abc.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntitiy,new()
    {
        T Get(Expression<Func<T,bool>> filter=null);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entitiy);

        void Update(T entitiy);

        void Delete(T entitiy);

    }
}
