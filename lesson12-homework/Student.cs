namespace lesson12_homework
{
    internal class Student : IComparable<Student>
    {
        public Student(string name, string lastName, int age, double score)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Score = score;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }

        public int CompareTo(Student? other)
        {
            return this.Score.CompareTo(other.Score);
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student
                && Name == student.Name
                && LastName == student.LastName
                && Age == student.Age
                && Score == student.Score;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
