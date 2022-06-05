using System;

namespace StrategyPattern
{
    public class TransactionB : ITransaction
    {
        public void Execute()
        {
            Console.WriteLine("Transaction B is executed");
        }
    }
}
