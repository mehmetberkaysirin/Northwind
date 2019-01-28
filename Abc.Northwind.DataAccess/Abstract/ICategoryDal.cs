using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Category ile özel operasyonlar
        //Stored Procodure
        //Wiev ile çalışmak
        //Joinli sorgular yazmak

    }
}
