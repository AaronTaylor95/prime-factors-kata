namespace kata
{
    public class PrimeFactorNode : IPrimeNode
    {
        private int _nodeValue;

        public PrimeFactorNode(int number)
        {
            _nodeValue = number;
        }

        public IPrimeNode Process(int factor = 2)
        {
            return this;
        }

        public int Value => _nodeValue;
    }
}
