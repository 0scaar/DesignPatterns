using BuilderPattern.Interface;
using BuilderPattern.Product;

namespace BuilderPattern
{
    public class ToyCreator
    {
        private IToyBuilder toyBuilder;

        public ToyCreator(IToyBuilder toyBuilder)
        {
            this.toyBuilder = toyBuilder;
        }

        public void CreateToy()
        {
            toyBuilder.SetModel();
            toyBuilder.SetHead();
            toyBuilder.SetLimbs();
            toyBuilder.SetBody();
            toyBuilder.SetLegs();
        }

        public Toy GetToy() => toyBuilder.GetToy();
    }
}
