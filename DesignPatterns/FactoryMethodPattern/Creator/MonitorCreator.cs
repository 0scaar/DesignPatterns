using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.Creator
{
    public class MonitorCreator : CreatorBase
    {
        public override IProduct FactoryMethod() => new Monitor();
    }
}
