using System;
namespace MyClass
{
    public class Magazine:Item
    {

        private String volume; 
        private int number; 
        private String title; 
        private int year;

        public Magazine(string volume, int number, string title, int year, long invNumber, bool taken)
            : base (invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public Magazine()
        {
        }


        public override void Info()
        {
            Console.WriteLine($"Журнал: Том журнала {volume}, номер журнала {number}, название {title}, год {year}");
            base.Info();

        }
      

        public override void ReturnItem()
        {
            taken = true;

        }

        public override void Return()
        {
            Console.WriteLine("...");
        }
    }
}

