using System;
using System.Collections.Generic;
using System.Text;
using Abc.Core.Entities;

namespace Abc.Northwind.Entities.Concrete
{
     public class Product:IEntitiy
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
