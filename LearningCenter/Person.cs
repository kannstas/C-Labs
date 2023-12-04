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
            int years;
            if (now.Month < personBirth.Month)
            {
                years = (now.Year - personBirth.Year) - 1;
                return years;
            }
            else if (now.Month == personBirth.Month)
            {
                if (now.Day < personBirth.Day || now.Day == personBirth.Day)
                {
                    years = (now.Year - personBirth.Year) - 1;
                    return years;

                }
                if (now.Day > personBirth.Day)
                {
                    years = now.Year - personBirth.Year;
                    return years;
                }
            }
            else
            {
                years = (now.Year - personBirth.Year);
                return years;
            }

            return 0;
        }
    }

}


