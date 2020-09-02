namespace kata
{
    public interface IPrimeNode
    {
        int Value { get; }
        IPrimeNode Process(int factor = 2);
    }
}
