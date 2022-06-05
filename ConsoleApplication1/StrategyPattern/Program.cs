using System;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var transactionClient = new TransactionClient(new TransactionB());

            transactionClient.Execute();

            Console.ReadLine();
        }
    }
}
