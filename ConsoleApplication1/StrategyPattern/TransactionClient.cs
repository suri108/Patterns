namespace StrategyPattern
{
    public class TransactionClient
    {
        private ITransaction _transaction;
        public TransactionClient(ITransaction transaction)
        {
            _transaction = transaction;
        }

        public void Execute()
        {
            _transaction.Execute();
        }
    }
}
