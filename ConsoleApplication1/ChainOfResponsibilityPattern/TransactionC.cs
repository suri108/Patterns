using System;

namespace ChainOfResponsibilityPattern
{
    public class TransactionC : AbstractTransaction
    {
        public override void Execute()
        {
            Console.WriteLine("Transaction C is executed");

            if (_nextTransaction != null)
            {
                _nextTransaction.Execute();
            }
        }
    }
}
