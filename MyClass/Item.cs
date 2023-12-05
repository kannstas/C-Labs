using System;
namespace MyClass
{
   public abstract class Item
    {

        protected long invNumber;

        protected bool taken;

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public Item()
        {
        }



        public Item(bool taken)
        {
            this.taken = true;
        }


       

        public bool IsAvailable()
        {
            if (taken == true)
            {
                return true;

            }
            else
                return false;
        }


        public long GetInvNumber()
        {
            return invNumber;
        }

        private void Take()
        {
            taken = false;

        }

        abstract public void Return();



        public virtual void Info()
        {
            Console.WriteLine($"Состояние единицы хранения: инвентарный номер: {invNumber}, наличие: {taken}");

        }

        public void TakeItem ()
        {
            if (IsAvailable())
                Take();
        }

        public virtual void ReturnItem ()
        {
            if (IsAvailable().Equals(false))
                Return();
             
        }
    }
}

