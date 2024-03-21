using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Control_Flow
{
	public class SwitchStatement
	{

		public SwitchStatement()
		{

		}

		public void switchusecase()
		{
			//switch s tament allows you to run a block of statement
			//where as the switch expression is similar but it expects a value into a variable 
			int statement = 0;
			// constraints teh statement in the switch needs some type of const value to equate it could not be at runtime , unless it equates to a constants at compile time
			// if break is not there and the statement as well it behaves as a stack 
			switch (statement)
			{
				case 1:
					Console.WriteLine("Monday");
					break;

				case 2:
					Console.WriteLine("Tuesday        ");
					break;

				case 3:
					Console.WriteLine("Thursday"); 
					//we caN USE the return as well if you want to exit form the whole functions
					return;

				case 4:
					Console.WriteLine("Friday");
					break;

				case 6:
				case 7:
					Console.WriteLine("Weekend");
					break;
					case8:
					Console.WriteLine("Weekend");
					break;
				default:
					Console.WriteLine("invalid day");
					break;

			}

		}

		public void SwitchExpression()
		{
			string Dayoftheweek = "Thursday";

			string result = Dayoftheweek switch
			{
				"Moday" => "First day",
				"Tuesday" => "Second day ",
				"Thursday" => " fourth day of week", // we can calculate some thing at runtime over here as well
				_ => "Default case invalid week" //discard pattern
			};

			 
		}
	}
}
