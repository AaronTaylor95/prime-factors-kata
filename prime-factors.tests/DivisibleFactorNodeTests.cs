using NUnit.Framework;
using kata;
using System;
using System.Collections.Generic;
using System.Text;

namespace prime_factors.tests
{
    [TestFixture]
    public class DivisibleFactorNodeTests
    {
        [Test]
        public void ShouldReturnCorrectPrimesFor360()
        {
            var root = new DivisibleFactorNode(360);
            root.Add(new PrimeFactorNode(2));
            
            var node180 = new DivisibleFactorNode(180);
            node180.Add(new PrimeFactorNode(2));
            
            var node90 = new DivisibleFactorNode(90);
            node90.Add(new PrimeFactorNode(3));
            
            var node30 = new DivisibleFactorNode(30);
            node30.Add(new PrimeFactorNode(3));

            var node10 = new DivisibleFactorNode(10);
            node10.Add(new PrimeFactorNode(2));
            node10.Add(new PrimeFactorNode(5));

            node30.Add(node10);
            node90.Add(node30);
            node180.Add(node90);
            root.Add(node180);

            var result = root.Process();

            Assert.That(result, Is.EqualTo(root));
        }

        [Test]
        public void ShouldReturnCorrectPrimesFor15()
        {
            var root = new DivisibleFactorNode(15);
            root.Add(new PrimeFactorNode(3));
            root.Add(new PrimeFactorNode(5));

            var result = root.Process();

            Assert.That(result, Is.EqualTo(root));
        }
    }
}
