
Customer Elena = new Customer("Елена Иванова", 500);

Elena.Call();

Console.WriteLine(Elena);




class Customer
{
    public string name;
    public double balance;

    private Call call = new Call();



    public Customer(string name, double balance)
    {
        this.name = name;
        this.balance = balance;
    }



    public override string ToString()
    {
        return string.Format("Клиент: {0} имеет баланс: {1}", name, balance);
    }

    public void Call() => call.RecordCall(this, 20);



}



class Call

{

    TimeBasedRate timeBasedRate = new TimeBasedRate();
    AfterTenMinutesCheaperRate afterTenMinutesCheaperRate = new AfterTenMinutesCheaperRate();
    PayLessUpToFiveMinutesRate payLessUpToFiveMinutesRate = new PayLessUpToFiveMinutesRate();



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
            "\n" +
            "Выберете тип звонка: \n" +
            "городской \n" +
            "мобильный \n"
             );

        string userCallType = Console.ReadLine();


        if (userRate == 1)
            timeBasedRate.CalculateTheCostOFTheCall(customer, userCallType, minutes);

        if (userRate == 2)
            afterTenMinutesCheaperRate.CalculateTheCostOFTheCall(customer, userCallType, minutes);

        if (userRate == 3)
            payLessUpToFiveMinutesRate.CalculateTheCostOFTheCall(customer, userCallType, minutes);



    }
}


class Record

{
    private Customer customer;



    public void RecordPayment(double amountPaid)
    {
        if (amountPaid > 0)
            customer.balance += amountPaid;
    }


}



class TimeBasedRate
{
    string urbanCall;
    string phoneCall;

    public TimeBasedRate()
    {

        urbanCall = "городской";
        phoneCall = "мобильный";
    }


    public double CalculateTheCostOFTheCall(Customer customer, string callType, int minutes)
    {
        if (callType.Equals(urbanCall))
        {
            return customer.balance -= minutes * 5;


        }
        else if (callType.Equals(phoneCall))
        {
            return customer.balance -= minutes * 1;
        }

        return 0;
    }


}

class AfterTenMinutesCheaperRate
{
    string urbanCall;
    string phoneCall;

    public AfterTenMinutesCheaperRate()
    {
        urbanCall = "городской";
        phoneCall = "мобильный";
    }

    public double CalculateTheCostOFTheCall(Customer customer, string callType, int minutes)
    {
        if (callType.Equals(urbanCall))
        {
            if (minutes > 10)
            {
                customer.balance -= 10 * 5;

                minutes = minutes - 10;

                return customer.balance -= (minutes * 5) / 2;
            }

            if (minutes <= 10)
            {
                return customer.balance -= minutes * 5;
            }
        }

        else if (callType.Equals(phoneCall))
        {
            return customer.balance -= minutes * 1;
        }

        return 0;
    }
}


class PayLessUpToFiveMinutesRate
{
    string urbanCall;
    string phoneCall;

    public PayLessUpToFiveMinutesRate()
    {
        urbanCall = "городской";
        phoneCall = "мобильный";
    }

    public double CalculateTheCostOFTheCall(Customer customer, string callType, int minutes)
    {
        if (callType.Equals(urbanCall))
        {
            if (minutes > 5)
            {
                customer.balance -= 5 * 2.5;

                minutes = minutes - 5;

                return customer.balance -= minutes * 10;
            }

            if (minutes <= 5)
            {
                return customer.balance -= minutes * 2.5;
            }
        }
        else if (minutes > 5)
        {
            customer.balance -= 5 * 0.5;

            minutes = minutes - 5;
            return customer.balance -= minutes * 2;
        }

        if (minutes <= 5)
        {
            return customer.balance -= minutes * 0.5;
        }

        return 0;
    }
}













