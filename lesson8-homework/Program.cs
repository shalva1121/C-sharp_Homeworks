namespace lesson8_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "John";
            student.Lastname = "Doe";
            student.StudentID = "12345";
            student.Age = 20;
            student.Gender = "Male";
            student.Email = "example@gmail.com";
            student.Phone = "555599873";
            student.Adress = "123 Main St";
            student.Grade = "A";
            student.GPA = 3.5;
            Console.WriteLine(student);
        }
    }
}
