using FactoryMethodPattern.Creator;
using FluentAssertions;
using Xunit;

namespace Tests.CreationalPatterns.FactoryMethod
{
    public class FactoryMethodTest
    {
        [Fact]
        public void ProductMonitorTest()
        {
            var message = "Creator: the same creator's code has just worked with {Result of Monitor class}";
            var monitor = new MonitorCreator();
            var result = monitor.SomeOperation();

            message.Equals(result).Should().BeTrue();
        }

        [Fact]
        public void ProductMouseTest()
        {
            var message = "Creator: the same creator's code has just worked with {Result of Mouse class}";
            var monitor = new MouseCreator();
            var result = monitor.SomeOperation();

            message.Equals(result).Should().BeTrue();
        }
    }
}
