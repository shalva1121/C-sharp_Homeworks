using System;
using System.Collections.Generic;
using System.Text;

namespace lesson10_homework
{
    internal class Nurse
    {
		private string _department;

		public string Department
        {
			get { return _department; }
			set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _department = value;
                }
            }
		}

	}
}
