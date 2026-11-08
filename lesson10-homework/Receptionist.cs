using System;
using System.Collections.Generic;
using System.Text;

namespace lesson10_homework
{
	internal class Receptionist
	{
		private Patient[] _registeredPatients;

		public Patient[] RegisteredPatients
        {
			get { return _registeredPatients; }
			set { _registeredPatients = value; }
		}


	}
}
