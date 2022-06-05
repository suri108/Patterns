using System;

namespace ChainOfResponsibilityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var transactionA = new TransactionA();
            var transactionB = new TransactionB();
            var transactionC = new TransactionC();

            transactionA.SetNextTransaction(transactionB);
            transactionB.SetNextTransaction(transactionC);

            transactionA.Execute();

            Console.ReadLine();
        }
    }
}
