using System;
using System.Collections.Generic;
using System.Text;

namespace lesson8_homework
{
    internal class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _name = value;
                }
            }
        }
        private string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _lastname = value;
                }
            }


        }
        private string _studentID;

        public string StudentID
        {
            get { return _studentID; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _studentID = value;
                }
            }

        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0 || value > 120)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _age = value;
                }
            }

        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _gender = value;
                }
            }


        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@"))
                {
                    Console.WriteLine("ERROR");

                }
                else
                {
                    _email = value;
                }
            }

        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value.Length != 9)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _phone = value;
                }
            }
        }
        private string _address;

        public string Adress
        {
            get { return _address; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _address = value;
                }
            }
        }

        private string _grade;

        public string Grade
        {
            get { return _grade; }
            set {
                if (string.IsNullOrWhiteSpace(value) || value.Length>2)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _grade = value;
                }
            }
        }
        private double _gpa;

        public double GPA
        {
            get { return _gpa; }
            set {
                if (value>4 || value<0)
                {
                    Console.WriteLine("ERROR");
                }
            }
        }

        public override string? ToString()
        {
            return $"Name:{Name} , Lastname:{Lastname}, StuentID:{StudentID}, Age:{Age}, Gender:{Gender} ,Email:{Email}, phone:{Phone} , Address{Adress} Grade:{Grade} , GPA:{GPA} ";
        }
    }

}