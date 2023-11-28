
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

        BankAccount.TransferFrom(firstBankAccount, secondBankAccount, 1000);

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
        if (bankAccount.ValidateTransfer(bankAccount, amount).Equals(true))
        {
            bankAccount.Deposit(amount);
            Write(bankAccount);
        }
    }

    static void Withdraw (BankAccount bankAccount)
    {
        Console.WriteLine("Введите сумму, которую хотите cписать");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (bankAccount.ValidateTransfer(bankAccount, amount).Equals(true))
        {
            bankAccount.Withdraw(amount);
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



    public bool ValidateTransfer (BankAccount account, decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Невозможно добавить на баланс отрицательную сумму");
            return false;
        } else if (account.accBal<amount)
        {
            Console.WriteLine("Невозможно списать денежные средства");
            return false;
        }

        return true;

    }

    public decimal Deposit(decimal amount)
    {
       
        return accBal += amount;
    }

    public decimal Withdraw(decimal amount)
    {
       return accBal -= amount;

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

    public static void TransferFrom(BankAccount accountFrom, BankAccount accountWhere, decimal amount)
    {

        //accountFrom.accBal = accountFrom.accBal- amount;
        //accountWhere.accBal = accountFrom.accBal + accountWhere.accBal;

        //Console.WriteLine($"Перевод прошел успешно c банковского счета {accountFrom.accNo} (баланс {accountFrom.accBal})" +
        //    $" на {accountWhere.accNo} (баланс {accountWhere.accBal}) прошел успешно");

        if (accountFrom.ValidateTransfer(accountFrom, amount).Equals(true))
        {
            accountFrom.Withdraw(amount);
            accountWhere.Deposit(amount);
        }

        Console.WriteLine($"Перевод прошел успешно c банковского счета {accountFrom.accNo} (баланс {accountFrom.accBal})" +
            $" на {accountWhere.accNo} (баланс {accountWhere.accBal}) прошел успешно");
    }

    public enum AccountType
    {
        Cheking,
        Deposit
    }
}



