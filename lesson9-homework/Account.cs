using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_homework
{
    internal class Account
    {
		private string _accountNumber;

		public string AccountNumber
		{
			get { return _accountNumber; }
			set {
                if (value.Length!=22)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _accountNumber=value;
                }
            }
		}
		private decimal _balance;

		public decimal Balance
		{
			get { return _balance; }
			set {
                if (value<0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _balance = value;
                }
            }
		}


	}
}
