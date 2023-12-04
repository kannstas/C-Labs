using LearningCenter;

Professor professor = new Professor("Пирогов", "02/24/1950", "юридический", "старший преподаватель", 15);

Administrator administrator = new Administrator("Рогов", "10/12/1999", 5, 10);

Manager manager = new Manager("Кудрявцев", "07/02/1980", "математический", "менеджер", 2);

Student student1 = new Student("Кошкина", "12/04/2002", "ПММ", 2);

Student student2 = new Student("Егоров", "03/03/2005", "ФКН", 1);

Student student3 = new Student("Любов", "10/12/2000", "Математический", 3);



List<Student> studentList = new List<Student>
{
    student1,
    student2,
    student3
};


foreach (Student student in studentList)
{
    Console.WriteLine(student);
}


