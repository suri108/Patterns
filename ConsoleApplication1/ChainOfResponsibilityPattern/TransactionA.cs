using System;

namespace ChainOfResponsibilityPattern
{
    public class TransactionA : AbstractTransaction
    {
        public override void Execute()
        {
            Console.WriteLine("Transaction A is executed");

            if (_nextTransaction != null)
            {
                _nextTransaction.Execute();
            }
        }
    }
}
