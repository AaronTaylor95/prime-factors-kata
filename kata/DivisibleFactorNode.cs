using System;
using System.Collections.Generic;

namespace kata
{
    public class DivisibleFactorNode : IPrimeNode
    {
        private List<IPrimeNode> _children = new List<IPrimeNode>();
        private int _nodeValue;

        public DivisibleFactorNode(int number)
        {
            _nodeValue = number;
        }
        
        public void Add(IPrimeNode child)
        {
            _children.Add(child);
        }

        public IPrimeNode Process(int factor = 2)
        {
            if(IsPrime(_nodeValue))
            {
                return new PrimeFactorNode(_nodeValue).Process();
            }
            else
            {
                if (_nodeValue % factor == 0)
                {
                    Add(new PrimeFactorNode(factor).Process());
                    Add(new DivisibleFactorNode(_nodeValue / factor).Process(factor));
                }
                else
                {
                    Process(factor + 1);
                }
            }

            return this;
        }
        private bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        public int Value => _nodeValue;

        public List<IPrimeNode> Nodes => _children;
    }
}
