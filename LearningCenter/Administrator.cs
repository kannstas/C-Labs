using System;
using System.Numerics;

namespace LearningCenter
{
    public class Administrator : Person, IEmployee
    {
        int numberOfLaboratory;
        int experience;

        public Administrator(string lastName, string dateOfBirth, int numberOfLaboratory, int experience)
             : base(lastName, dateOfBirth)
        {
            this.numberOfLaboratory = numberOfLaboratory;
            this.experience = experience;
        }

        public void CommunicаtionWithStudents()
        {
            Console.WriteLine("Администратор общается со студентами");
        }

        public void Info()
        {
            Console.WriteLine("Это администратор");
        }

        public double Salary()
        {
            return experience*10;
        }

        public override int CalculateAge()
        {
            return base.CalculateAge();
        }

    }
}

