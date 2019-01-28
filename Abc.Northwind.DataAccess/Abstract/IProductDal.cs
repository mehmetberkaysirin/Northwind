using Abc.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Product ile özel operasyonlar
        //Stored Procodure
        //Wiev ile çalışmak
        //Joinli sorgular yazmak

    }
   
}
