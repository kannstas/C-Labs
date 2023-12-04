
public class BankTransaction
{
    private readonly decimal transactionAmount;
    private readonly DateTime when;

    public decimal TransactionAmount()
    {
        return transactionAmount;
    }

    public DateTime When()
    {
        return when;
    }
    public BankTransaction(decimal transactionAmount)
    {
        this.transactionAmount = transactionAmount;
        when = DateTime.Now;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

