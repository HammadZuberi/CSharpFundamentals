using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
	internal class CastingAndParsing
	{
		//how do we convert between different variable types?
		//we can "Cast "them , which means to convert them to a different type/

		//implicit type casting eg int to double c
		//casting smaller data type to a larger one without cast keyword
		public CastingAndParsing()
		{
			int IntA = 5;
			double myDouble = IntA;

			Console.WriteLine("IMplicit CAST\n");
			Console.WriteLine($"myInt{IntA} \n mydouble {myDouble}");


			//we can also "explicitly" cast between types that are compatible 
			myDouble = 5.5;
			IntA = (int)myDouble;
			Console.WriteLine("Explicit CAST\n");
			Console.WriteLine($"myInt{IntA} \n mydouble {myDouble}");



			string mystring = "5";
			//int myInt = (int)mystring; // we can not cast it give and error C#
			// we can parse the strign inot the int \
			//compiler can not determine ahead of time runtime error can occur

			IntA = int.Parse(mystring);
			Console.WriteLine("Parsse");

			Console.WriteLine($"myint{IntA} from mystrign {mystring}");

			mystring = "6.5";
			myDouble = double.Parse(mystring);
			Console.WriteLine($"myDouble{myDouble} from mystrign {mystring}");
		}



		//explicit type casting

		//
	}
}
