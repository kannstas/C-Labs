using System;
namespace LearningCenter
{
	public class Professor : Person, IEmployee
	{
		string faculty;
		string post;
		int experience;

        public Professor(string lastName, string dateOfBirth, string faculty, string post, int experience)
            : base(lastName, dateOfBirth)
        {
            this.faculty = faculty;
            this.post = post;
            this.experience = experience;
        }

        public void CommunicаtionWithStudents()
        {
            Console.WriteLine("Профессор общается со студентами");
        }

        public void Info()
        {
            Console.WriteLine("Это профессор");
        }

        public double Salary()
        {
            return experience * 15;
        }

        public override int CalculateAge()
        {
            return base.CalculateAge();
        }
    }
}

