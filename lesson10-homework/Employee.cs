using System;
using System.Collections.Generic;
using System.Text;

namespace lesson10_homework
{
    internal class Employee
    {
		private string _fullName;

		public string FullName
		{
			get { return _fullName; }
			set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _fullName = value;
                }
            }
		}

		private decimal _salary;

        public decimal Salary
        {
			get { return _salary; }
			set {
                if (value<0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _salary = value;
                }
            }
		}

        public void ShowInfo()
        {
            Console.WriteLine($"მომუშავე პირი:{FullName}");
            Console.WriteLine($"შემოსავალი:{Salary}");
        }
	}
}
