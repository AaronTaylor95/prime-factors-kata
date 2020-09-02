using NUnit.Framework;
using prime_factors_kata;

namespace prime_factors.tests
{
    [TestFixture]
    public class PrimeFactorNodeTests
    {
        [Test]
        public void ShouldSetNodeValueToValuePassedIntoConstructor()
        {
            var expected = 1;

            var sut = new PrimeFactorNode(expected);

            Assert.That(sut.Value, Is.EqualTo(expected));
        }

        [Test]
        public void ShouldReturnSelfAsNoFurtherFactors()
        {
            var sut = new PrimeFactorNode(3);

            var result = sut.Process();

            Assert.That(sut, Is.EqualTo(result));
        }
    }
}