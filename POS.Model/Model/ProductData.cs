﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Model
{
    public class ProductData
    {
        public string ProductName { get; }

        public ProductData(string name)
        {
            ProductName = name;
        }
    }
}
