using System;
using System.Collections.Generic;
using System.Text;
using Abc.Core.DataAccess.EntitiyFramework;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EFProductDal:EfEntitiyRepositoryBase<Product,NorthwindContext>,IProductDal
    {

    }
}
