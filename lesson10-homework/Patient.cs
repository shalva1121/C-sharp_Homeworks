using System;
using System.Collections.Generic;
using System.Text;

namespace lesson10_homework
{
    internal class Patient
    {
        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set
            {
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
    }
}
