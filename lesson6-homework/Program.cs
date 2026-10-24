namespace lesson6_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==================================== დავალება 1 ==================================

            //int first = ReadScore("Enter first exam score:");
            //int second = ReadScore("Enter second exam score:");
            //int third = ReadScore("Enter third exam score:");

            //Console.WriteLine("");
            //Console.WriteLine("the average score:");
            //Console.WriteLine(CalculateAverage(first, second, third));
            //Console.WriteLine("");
            //Console.WriteLine("students grade:");
            //Console.WriteLine(GetLetterGrade([ first, second, third ]));
            //Console.WriteLine("students pass:");
            //Console.WriteLine(IsPassed([ first, second, third ]));


            //bool IsValidScore(int x)
            //{
            //    return x >= 0 && x <= 100;
            //}

            //int ReadScore(string message)
            //{
            //    Console.WriteLine(message);
            //    int score;

            //    while (!int.TryParse(Console.ReadLine(), out score) || !IsValidScore(score))
            //    {
            //        Console.WriteLine("invalid score");
            //        Console.WriteLine("Enter exam score again:");
            //    }

            //    return score;
            //}


            //==================================== დავალება 2 ==================================

            //Console.WriteLine("enter number:");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsEven(num));
            //Console.WriteLine(IsPrime(num));
            //Console.WriteLine(CountDigits(num));
            //Console.WriteLine(ReverseNumber(num));

        }



        static int CalculateAverage(int x, int y, int z)
        {

            int average = (x + y + z) / 3;
            return average;
        }
        static string GetLetterGrade(int[] grades)
        {
            int count = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                count++;

                if (grades[i] >= 90)
                {
                    Console.WriteLine($"exam {count} grade: A");
                }
                else if (grades[i] >= 80)
                {
                    Console.WriteLine($"exam {count} grade: B");
                }
                else if (grades[i] >= 70)
                {
                    Console.WriteLine($"exam {count} grade: C");
                }
                else if (grades[i] >= 60)
                {
                    Console.WriteLine($"exam {count} grade: D");
                }
                else
                {
                    Console.WriteLine($"exam {count} grade: F");
                }
            }
            return "";

        }
        static string IsPassed(int[] grades)
        {
            int count = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                count++;

                if (grades[i] >= 90)
                {
                    Console.WriteLine($"exam {count} : Student passed");
                }
                else if (grades[i] >= 80)
                {
                    Console.WriteLine($"exam {count} : Student passed");
                }
                else if (grades[i] >= 70)
                {
                    Console.WriteLine($"exam {count} : Student passed");
                }
                else if (grades[i] >= 60)
                {
                    Console.WriteLine($"exam {count} : Student faild");
                }
                else
                {
                    Console.WriteLine($"exam {count} : Student faild");
                }
            }
            return "";
        }

        static string IsEven(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
            return "";

        }
        static string IsPrime(int x)
        {
            if (x <= 1)
            {
                Console.WriteLine("the number is not prime");
            }
            else if (x % 2 == 0 && x != 2)
            {
                Console.WriteLine("the number is not prime");
            }
            else if (x % 3 == 0 && x != 3)
            {
                Console.WriteLine("the number is not prime");
            }
            else if (x % 4 == 0 && x != 4)
            {
                Console.WriteLine("the number is not prime");
            }
            else if (x % 5 == 0 && x != 5)
            {
                Console.WriteLine("the number is not prime");
            }
            else if (x % 6 == 0 && x != 6)
            {
                Console.WriteLine("the number is not prime");
            }
            else if (x % 7 == 0 && x != 7)
            {
                Console.WriteLine("the number is not prime");
            }

            else if (x % 8 == 0 && x != 8)
            {
                Console.WriteLine("the number is not prime");
            }
            else if (x % 9 == 0 && x != 9)
            {
                Console.WriteLine("the number is not prime");
            }
            else
            {
                Console.WriteLine("the number is  prime");
            }
            return "";
        }
        static string CountDigits(int x)
        {
            int count = 0;
            while (x != 0)
            {
                x /= 10;
                count++;
            }
            return $"total digits:  {count}";
        }
        static string ReverseNumber(int x)
        {
            x.ToString();
            char[] charArray = x.ToString().ToCharArray();
            Console.WriteLine();
            Console.Write("Reverse number:  ");

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                Console.Write(charArray[i]);
            }
            return "";
        }
    }
}