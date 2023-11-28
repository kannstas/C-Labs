
Customer Elena = new Customer("Елена Иванова", 500);

Rate rate = new Rate();

rate.RecordCall(Elena, 30);

Console.WriteLine(Elena);




class Customer
{
    public string Name;
    public double Balance;

    public Customer(string name, double balance = 100)
    {
        Name = name;
        Balance = balance;
    }

    public override string ToString()
    {
        return string.Format("Клиент: {0} имеет баланс: {1}", Name, Balance);
    }

   
}


class Record

{
    private Customer customer;

    public void RecordPayment(double amountPaid)
    {
        if (amountPaid > 0)
            customer.Balance += amountPaid;
    }
}

class Rate // тариф
{


    public void RecordCall(Customer customer, int minutes)
    {
        Console.WriteLine
            (
            "Выберете тариф \n" +
            "1. Повременный: «городской» (5 руб./мин.) и «мобильный» (1 руб./мин.);\n" +
            "2. После10МинутВ2РазаДешевле: после 10 минут звонка на городской номер каждая вторая минута бесплатно; в остальном как Повременный;\n" +
            "3. ПлатиМеньшеДо5Минут: до 5 минут разговора в 2 раза дешевле тарифа Повременный, после - в 2 раза дороже.\n"
            );
        int userRate = int.Parse(Console.ReadLine());

        Console.WriteLine
            (
            "Выберете тип звонка: \n" +
            "1. Городской \n" +
            "2. Мобильный"
             );

        int userCallType = int.Parse(Console.ReadLine());


        switch (userRate, userCallType)
        {
            case (1, 1): customer.Balance -= minutes * 5; break;
            case (1, 2): customer.Balance -= minutes * 1; break;
            case (2, 1):
                {
                    if (minutes > 10)
                    {
                        customer.Balance -= 10 * 5;


                        minutes = minutes - 10;
                        customer.Balance -= (minutes * 5) / 2;
                    }

                    if (minutes <= 10)
                    {
                        customer.Balance -= minutes * 5;
                    }

                    break;
                }
            case (2, 2): customer.Balance -= minutes * 1; break;

            case (3, 1):
                {

                    if (minutes > 5)
                    {
                        customer.Balance -= 5 * 2.5;

                        minutes = minutes - 5;
                        customer.Balance -= minutes * 10;
                    }

                    if (minutes <= 5)
                    {
                        customer.Balance -= minutes * 2.5;
                    }

                    break;
                }

            case (3, 2):
                {


                    if (minutes > 5)
                    {
                        customer.Balance -= 5 * 0.5;

                        minutes = minutes - 5;
                        customer.Balance -= minutes * 2;
                    }

                    if (minutes <= 5)
                    {
                        customer.Balance -= minutes * 0.5;
                    }

                    break;
                }
        }
    }

 }

  





        


    

