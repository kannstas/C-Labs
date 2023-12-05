using System;
using System.Numerics;

namespace MyClass
{
    public class Book : Item 
    {
        private String author;
        private String title;
        private String publisher;
        private int pages;
        private int year;

        private bool returnTime;

        private static double price = 9;

        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }



        public Book()
        {
        }

        static Book()
        {
            price = 10;
        }





        public static void SetPrice(double price)
        {
            Book.price = price;
        }



        public override void Info()
        {
            Console.WriteLine($"Название книги {title}, автор {author}, издательство {publisher}, " +
               $"год издания {year}, количество страниц {pages}");

            base.Info();
        }





        public double PriceBook(int numberOfDays)
        {
            double cost = numberOfDays * price;
            return cost;
        }

        public void ReturnTime()
        {
            returnTime = true;
        }


        public override void ReturnItem()
        {
            if (returnTime == true)
            {
                taken = true;
            }
            else
                taken = false;
        }

        public override void Return()
        {
            Console.WriteLine("...");
        }


        public bool ifSubs { get; set; }

        public void Subscribe ()
        {
            Console.WriteLine($"Подписка на журнал {title}, {ifSubs}");
        }
    }
}

