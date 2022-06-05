namespace ChainOfResponsibilityPattern
{
    public abstract class AbstractTransaction
    {
        public AbstractTransaction _nextTransaction;

        public abstract void Execute();

        public void SetNextTransaction(AbstractTransaction nextTransaction)
        {
            _nextTransaction = nextTransaction;
        }

    }
}
