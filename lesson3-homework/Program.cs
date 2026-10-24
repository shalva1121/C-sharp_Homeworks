namespace lesson3_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //===================================== დავალება 1 =====================================

            //int trueNumber = new Random().Next(0, 100); 
            //Console.WriteLine("Guess the number!");

            //for (int i = 0; i < 7; i++)
            //{
            //    bool isvalid = int.TryParse(Console.ReadLine(), out int number);

            //    if (isvalid)
            //    {

            //        if (number == trueNumber)
            //        {
            //            Console.WriteLine("Correct!");
            //            return;
            //        }
            //        else if (number < trueNumber)
            //        {
            //            Console.WriteLine("Too low");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Too high");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //    }
            //    if (i == 6)
            //    {
            //        Console.WriteLine($"Sorry, you've used all your attempts. The correct number was {trueNumber}.");
            //    }
            //}


            //===================================== დავალება 2 =====================================

            //Console.WriteLine("Enter students number:");
            //bool isvalid = int.TryParse(Console.ReadLine(), out int studentsNumber);
            //int passedStudents = 0;
            //if (!isvalid || studentsNumber <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number of students.");

            //}
            //else
            //{
            //    for (int i = 0; i < studentsNumber; i++)
            //    {
            //        Console.WriteLine("Enter student grade:");
            //        bool isvalidGrade = int.TryParse(Console.ReadLine(), out int studentGrade);
            //        if (isvalidGrade)
            //        {
            //            if (studentGrade > 100 || studentGrade < 0)
            //            {
            //                Console.WriteLine("That kind of grade doesn't exist!");
            //                studentsNumber++;
            //            }
            //            else
            //            {
            //                if (studentGrade >= 90)
            //                {
            //                    Console.WriteLine("A");
            //                    Console.WriteLine("Student passed!");
            //                    passedStudents++;
            //                }
            //                else if (studentGrade >= 80)
            //                {
            //                    Console.WriteLine("B");
            //                    Console.WriteLine("Student passed!");
            //                    passedStudents++;

            //                }
            //                else if (studentGrade >= 70)
            //                {
            //                    Console.WriteLine("C");
            //                    Console.WriteLine("Student passed!");
            //                    passedStudents++;

            //                }
            //                else if (studentGrade >= 60)
            //                {
            //                    Console.WriteLine("D");

            //                }

            //                else
            //                {
            //                    Console.WriteLine("F");
            //                }
            //            }


            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid grade.");
            //            studentsNumber++;

            //        }
            //        if (i == studentsNumber - 1)
            //        {
            //            Console.WriteLine($"Number of students who passed: {passedStudents}");
            //        }
            //    }
            //}
        }
    }
}