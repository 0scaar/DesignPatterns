using BuilderPattern;
using BuilderPattern.Builders;
using FluentAssertions;
using Xunit;

namespace Tests.CreationalPatterns.Builder
{
    public class BuilderTest
    {
        [Fact]
        public void ToyABuilderTest()
        {
            var toyABuilder = new ToyABuilder();
            var toyACreator = new ToyCreator(toyABuilder);
            toyACreator.CreateToy();

            var toy = toyACreator.GetToy();

            toy.Model.Equals("Toy A").Should().BeTrue();
            toy.Body.Equals("Plastic").Should().BeTrue();
            toy.Head.Equals("1").Should().BeTrue();
            toy.Legs.Equals("2").Should().BeTrue();
            toy.Limbs.Equals("4").Should().BeTrue();
        }

        [Fact]
        public void ToyBBuilderTest()
        {
            var toyBBuilder = new ToyBBuilder();
            var toyBCreator = new ToyCreator(toyBBuilder);
            toyBCreator.CreateToy();

            var toy = toyBCreator.GetToy();

            toy.Model.Equals("Toy B").Should().BeTrue();
            toy.Body.Equals("Steel").Should().BeTrue();
            toy.Head.Equals("1").Should().BeTrue();
            toy.Legs.Equals("4").Should().BeTrue();
            toy.Limbs.Equals("4").Should().BeTrue();
        }
    }
}
