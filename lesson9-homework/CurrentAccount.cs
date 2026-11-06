using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_homework
{
    internal class CurrentAccount : Account
    {
		private decimal _overDraftLimit;

		public decimal OverdraftLimit
        {
            get { return _overDraftLimit; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _overDraftLimit = value;
                }
            }
		}

	}
}
