using System;
namespace LearningCenter
{
    public class Manager : Person, IEmployee
    {
        string faculty;
        string post;
        int experience;

        public Manager(string lastName, string dateOfBirth, string faculty, string post, int experience)
        : base(lastName, dateOfBirth)
        {
            this.faculty = faculty;
            this.post = post;
            this.experience = experience;
        }

        public void Info()
        {
            Console.WriteLine("Это менеджер");
        }

        public double Salary()
        {
            return experience*10;
        }

        public void CommunicаtionWithStudents()
        {
            Console.WriteLine("Менеджер общается со студентами");
        }

        public override int CalculateAge()
        {
            return base.CalculateAge();
        }
    }


}


