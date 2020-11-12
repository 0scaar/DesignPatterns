using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.Creator
{
    public class MouseCreator : CreatorBase
    {
        public override IProduct FactoryMethod() => new Mouse();
    }
}
