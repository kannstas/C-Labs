
using System.Security.Principal;
using Banking;

class CreateAccount
{
    static void Main()
    {

        BankAccount firstBankAccount = new BankAccount (534351, 454434, BankAccount.AccountType.Cheking);
        BankAccount secondBankAccount = new BankAccount(534353, 454434, BankAccount.AccountType.Cheking);

      

        Console.WriteLine(firstBankAccount.Equals(secondBankAccount));


        Audit audit = new Audit("AuditTrail.cs");
        BankTransaction bankTransaction = new BankTransaction(500);

        AuditEventArgs auditEventArgs = new AuditEventArgs(bankTransaction);

        audit.RecordTransaction(auditEventArgs);




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

    public BankAccount(long accNo, decimal accBal, AccountType accType)
    {
        this.accNo = accNo;
        this.accBal = accBal;
        this.accType = accType;
    }

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



   public static bool operator == (BankAccount account1, BankAccount account2)
    {
        if (account1.accBal == account2.accBal
            && account1.accNo == account2.accNo
            && account1.accType == account2.accType)
        {
            return true;
        } else 
        return false;
    }

    public static bool operator != (BankAccount account1, BankAccount account2)
    {
        return !(account1 == account2);
    }


    public override bool Equals(object account1)
    {
        return this == (BankAccount)account1;
    }



    public enum AccountType
    {
        Cheking,
        Deposit
    }
}



