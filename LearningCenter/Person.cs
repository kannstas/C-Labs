using System;
namespace LearningCenter
{
    abstract public class Person
    {
        
        protected string lastName;
        protected readonly string dateOfBirth;

        private DateTime personBirth;
       


        protected Person(string lastName, string dateOfBirth)
        {
            this.lastName = lastName;
            personBirth = DateTime.Parse(dateOfBirth);

        }


        public virtual int CalculateAge()
        {
            DateTime now = DateTime.Now;
            int years = (now.Year - personBirth.Year);
            return years;
        }
    }

}


