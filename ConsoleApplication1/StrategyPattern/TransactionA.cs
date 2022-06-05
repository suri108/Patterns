using System;

namespace StrategyPattern
{
    public class TransactionA : ITransaction
    {
        public void Execute()
        {
            Console.WriteLine("Transaction A is executed");
        }
    }
}
