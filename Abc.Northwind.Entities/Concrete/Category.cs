﻿using Abc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Entities.Concrete
{
    public class Category:IEntitiy
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
