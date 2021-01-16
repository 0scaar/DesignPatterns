using FactoryMethodPattern.Interfaces;
using System;

namespace FactoryMethodPattern
{
    public abstract class CreatorBase
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();

            var result = "Creator: the same creator's code has just worked with " 
                + product.Operation();

            return result;
        }
    }
}
