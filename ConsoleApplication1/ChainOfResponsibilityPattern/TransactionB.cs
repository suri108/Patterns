using System;

namespace ChainOfResponsibilityPattern
{
    public class TransactionB : AbstractTransaction
    {
        public override void Execute()
        {
            Console.WriteLine("Transaction B is executed");

            if (_nextTransaction != null)
            {
                _nextTransaction.Execute();
            }
        }
    }
}
