using prime_factors_kata;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeFactor = new DivisibleFactorNode(360).Process();

            Print(primeFactor as DivisibleFactorNode);
            Console.ReadLine();
        }
        static void Print(DivisibleFactorNode divisibleNode)
        {
            Console.WriteLine($"Div: {divisibleNode.Value}");
            foreach (var node in divisibleNode.Nodes)
            {
                if (node is DivisibleFactorNode)
                {
                    Print(node as DivisibleFactorNode);
                }
                else
                {
                    Console.WriteLine($"node: {node.Value}");
                }
            }
        }
    }
}
