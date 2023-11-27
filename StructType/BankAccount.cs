
class CreateAccount
{
    static void Main()
    {
        BankAccount firstBankAccount = NewBankAccount();

        Write(firstBankAccount);

        Withdraw(firstBankAccount);
            
        BankAccount secondBankAccount = NewBankAccount();

        Write(secondBankAccount);

        TestDeposit(secondBankAccount);



    }

    static BankAccount NewBankAccount()
    {
        BankAccount bankAccount = new BankAccount();

        Console.WriteLine("Введите баланс");

        decimal balance = decimal.Parse(Console.ReadLine());

        bankAccount.Populate(balance);


        return bankAccount;
    }

    static void TestDeposit (BankAccount bankAccount)
    {
        Console.WriteLine("Введите сумму, которую хотите положить на счет");
        decimal amount = decimal.Parse(Console.ReadLine());
        bankAccount.Deposit(amount);
        Write(bankAccount);
    }

    static void Withdraw (BankAccount bankAccount)
    {
        Console.WriteLine("Введите сумму, которую хотите cписать");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (bankAccount.Withdraw(amount) == true)
        {
            Write(bankAccount);
        } 
    }


    static void Write(BankAccount bankAccount)
    {
        Console.WriteLine($"Номер банковского счета клиента {bankAccount.Number()}, " +
        $"тип банковского счета {bankAccount.Type()}, баланс счета {bankAccount.Balance()}");
    }

}


class BankAccount
{
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccountNumber = 123;




    public void Populate(decimal accountBalance)
    {
        accNo = NextNumber();
        accBal = accountBalance;
        accType = AccountType.Cheking;
    }


    public decimal Deposit (decimal amount)
    {
        if (amount<0)
        {
            Console.WriteLine("Невозможно добавить на баланс отрицательную сумму");
        }

        return accBal += amount;
    }

    public bool Withdraw (decimal amount)
    {
        if ((accBal>=amount) && (amount>0))
        {
            accBal -= amount;

            return true;
        } else
        {
            Console.WriteLine("Невозможно списать денежные средства");
            return false;
        }
    }


     private long NextNumber ()
     {
     return nextAccountNumber++;
     }

     public long Number ()
     {
     return accNo;
     }

     public decimal Balance ()
     {
      return accBal;
     }

     public string Type()
     {
      return accType.ToString();
     }



 }

public enum AccountType
{
    Cheking,
    Deposit
}





