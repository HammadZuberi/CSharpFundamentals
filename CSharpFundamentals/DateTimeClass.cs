using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
	internal class DateTimeClass
	{
		//DAte tiem can stored into Datetime variabels
		//DAtes can be assigned to a Datetiem only variable 
		// tiems can be assigned to timeonly variabel 

		DateTime DateTime;
		DateOnly DateOnly;
		TimeOnly TimeOnly;

		public DateTimeClass()
		{
			DateTime = DateTime.Now;
			TimeOnly = new TimeOnly(1, 23, 45);
			DateOnly = new DateOnly(2024, 1, 23);


			//we can replace them as well

			DateTime = DateTime.Now.AddDays(2);
			TimeOnly = new TimeOnly(1, 25, 45);
			DateOnly = new DateOnly(2025, 1, 23);

			//date and time are complex ..consider multi timezones

			//dateime form combination

			DateTime date = new DateTime(DateOnly, TimeOnly);

			Console.WriteLine($"DAte and Time {DateTime}");
			Console.WriteLine($"DAte {DateOnly}");
			Console.WriteLine($" Time {TimeOnly}");


		}

	}
}
