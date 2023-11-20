

BankAccount goldAccount;
Console.WriteLine("Введите номер банковского счета");

goldAccount.accNo = long.Parse(Console.ReadLine());

goldAccount.accType = AccountType.Cheking;
goldAccount.accBal = (decimal) 320.78;


Console.WriteLine($"Номер банковского счета клиента {goldAccount.accNo}, " +
    $"тип банковского счета {goldAccount.accType}, баланс счета {goldAccount.accBal}");



public enum AccountType
{
    Cheking,
    Deposit
}

public struct BankAccount
{
    public long accNo;
    public decimal accBal;
    public AccountType accType;

  
}

