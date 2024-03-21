using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Control_Flow
{
	public class IfStatements
	{
		public IfStatements()
		{

		}

		public void Ifconditions()
		{

			if (true) { Console.Write("This line  prints "); }

			if (false) { Console.Write("Thios line never prints "); }

			if (!false) { Console.Write("Thios line never prints "); }
			else { }
		}

		public void Ternararyoperator()
		{
			//variable =(condition) ? experessionTrue : expression False\\
			//use a small if statement or single line operator  
			int x = 10;
			string result = x > 5 ? "x is greater than 5" : "x is less than 5";
			Console.WriteLine(result);
			result = x == 5 ? "x is greater than 5" : "x is less than 5";

			Console.WriteLine(result);
		}

		public void IfwithOperators()
		{
			////< is "less thasn operator",
			///> is "greator than op"
			///<= "less than equals"
			///>= "grter than equals"
			///== "eqquals to " operator
			/// != "no tequal to "
			/// = "Assignment operator.
			/// 
			int num = 5;
			if (num < 5)
			{
				Console.WriteLine("number is less than 5");
			}
			else if (num == 5)
			{
				Console.WriteLine("number is equal to 5");
			}
			else if (num > 2)
			{
				Console.WriteLine("number is greater to 2");
			}
			else
			{

				Console.WriteLine("number is greater to 2");
			}

			// adn and or operator && and ||
			num = 3;
			if (num >= 1 && num <= 5)
			{
				Console.WriteLine("number is grater than and less than 5");
			}
			else
			{
				Console.WriteLine("number is grater than and less than 5");

			}

			if (num < 1 || num > 5)
			{
				Console.WriteLine("number is grater than or less than 5");
			}
			else
			{
				Console.WriteLine("number is grater than or less than 5");

			}
		}
	}
}
