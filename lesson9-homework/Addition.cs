using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_homework
{
    internal class Addition :Account
    {
		private string _cardNumber;

		public string CardNumber
		{
			get { return _cardNumber; }
			set {
                if (value.Length>16)
                {
                    Console.WriteLine("ERROR");
                }
            }
		}
        public string ExpDate { get; set; }
    }
}
