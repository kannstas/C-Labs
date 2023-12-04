using System;
namespace LearningCenter
{
    public class Student : Person
    {
        string faculty;
        int group;
        int age;

        public Student(string lastName, string dateOfBirth, string faculty, int group)
            : base(lastName, dateOfBirth)
        {
            this.faculty = faculty;
            this.group = group;
            age = CalculateAge();
        }

        public override string ToString()
        {
            return $"Студент {lastName}, {age} лет, факультет {faculty}, группа {group}";
        }

        public override int CalculateAge()
        {
            return base.CalculateAge();
        }
    }



    
}

