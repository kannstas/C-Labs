
using System.Security.Principal;

class CreateAccount
{
    static void Main()
    {


        using (BankAccount acc1 = new BankAccount())
        {
            acc1.Deposit(100);
            acc1.Withdraw(50);
            acc1.Deposit(75);
            acc1.Withdraw(50);
            acc1.Withdraw(30);
            acc1.Deposit(40);
            acc1.Deposit(200);
            acc1.Withdraw(250);
            acc1.Deposit(25);
            Write(acc1);


        }



        // работа с конструкторами

        BankAccount ac1, ac2, ac3, ac4;

        ac1 = new BankAccount();
        ac2 = new BankAccount(BankAccount.AccountType.Deposit);
        ac3 = new BankAccount(BankAccount.AccountType.Deposit, 500);
        ac4 = new BankAccount(100);

        Console.WriteLine(ac1);
        Console.WriteLine(ac2);
        Console.WriteLine(ac3);
        Console.WriteLine(ac4);

        ac3.Withdraw(100);
        Write(ac3);

    }

    static BankAccount NewBankAccount()
    {
        BankAccount bankAccount = new BankAccount();

        Console.WriteLine("Введите баланс");

        decimal balance = decimal.Parse(Console.ReadLine());


        return bankAccount;
    }


    static void Write(BankAccount bankAccount)
    {
        Console.WriteLine($"Номер банковского счета клиента {bankAccount.Number()}, " +
        $"тип банковского счета {bankAccount.Type()}, баланс счета {bankAccount.Balance()}");

        Console.WriteLine("Транзакции:");
       
        foreach (BankTransaction transaction in bankAccount.Transaction())
        {
            Console.WriteLine($"дата/время {transaction.When}, сумма {transaction.TransactionAmount}");
        }
    }

}


sealed class BankAccount : IDisposable
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccountNumber = 123;

    Object disposed = false;



    private Queue<BankTransaction> tranQueue = new Queue <BankTransaction>();

    public BankAccount ()
    {
        accNo = NextNumber();
        accType = AccountType.Cheking;
        accBal = 0;
    }

    public BankAccount (AccountType type)
    {
        accNo = NextNumber();
        accType = type;
        accBal = 0;
    }

    public BankAccount (decimal balance)
    {
        accNo = NextNumber();
        accType = AccountType.Cheking;
        accBal = balance;
    }


    public BankAccount(AccountType type, decimal balance)
    {
        accNo = NextNumber();
        accType = type;
        accBal = balance;
    }


    public override string ToString()
    {
        return $"{accNo},{accType}, {accBal}, {tranQueue}";
    }



    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransaction tran = new BankTransaction(amount);
        tranQueue.Enqueue(tran);
        return accBal;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
            BankTransaction transaction = new BankTransaction(-amount);
            tranQueue.Enqueue(transaction); 
        }
        return sufficientFunds;

    }


    private long NextNumber()
    {
        return nextAccountNumber++;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    public string Type()
    {
        return accType.ToString();
    }


    public void Dispose ()
    {
        if (!(bool)disposed)
        {
            
        } else if ((bool) disposed)
        {
            StreamWriter streamFile = File.AppendText("Transactions.Dat");
            streamFile.WriteLine($"номер аккаунта  {accNo}");
            streamFile.WriteLine($"баланс  {accBal}");
            streamFile.WriteLine($"тип аккаунта {accType}");

            streamFile.WriteLine("Транзакции");
            foreach (BankTransaction transaction in tranQueue)
            {

                Console.WriteLine($"дата/время {transaction.When}, сумма {transaction.TransactionAmount}");
            }

            streamFile.Close();
            disposed = true;
            GC.SuppressFinalize(this);
        }

    }

    public Queue<BankTransaction> Transaction ()
    {
        
        return tranQueue;
    }



    


    public enum AccountType
    {
        Cheking,
        Deposit
    }
}



