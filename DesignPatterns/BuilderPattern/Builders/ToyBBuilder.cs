using BuilderPattern.Interface;
using BuilderPattern.Product;

namespace BuilderPattern.Builders
{
    public class ToyBBuilder : IToyBuilder
    {
        Toy toy = new Toy();

        public Toy GetToy() => toy;
        public void SetBody() => toy.Body = "Steel";
        public void SetHead() => toy.Head = "1";
        public void SetLegs() => toy.Legs = "4";
        public void SetLimbs() => toy.Limbs = "4";
        public void SetModel() => toy.Model = "Toy B";
    }
}
