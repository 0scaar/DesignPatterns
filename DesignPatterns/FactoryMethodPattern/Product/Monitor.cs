using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Product
{
    public class Monitor : IProduct
    {
        public string Operation()
        {
            return "{Result of Monitor class}";
        }
    }
}
