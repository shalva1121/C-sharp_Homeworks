using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
	internal class NumberArray : IOutput2, ICalc2
	{


		private int[] _data;
		
		public NumberArray(int[] data)
		{
			_data = data;
		}

		public int CountDistinct()
		{
			int notdistinctCount = 0;
			foreach (var item in _data)
			{
				int count = 0;
				foreach (var item1 in _data)
				{
					if(item == item1)
					{
						count++;
					}
				}
				if(count >1)
				{
					notdistinctCount++;
				}
			}

			return _data.Length - notdistinctCount;
		}

		public void ShowEven()
		{
			foreach (var item in _data)
			{
				if(item % 2 == 0)
				{
					Console.WriteLine(item);
				}
			}
		}

		public void ShowOdd()
		{
			foreach (var item in _data)
			{
				if(item % 2 != 0)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}
