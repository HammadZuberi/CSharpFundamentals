using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
	public class BasicValueTypes
	{

		//string literal 
		string FirstName = "John";
		//delcare value
		string nameString;

		public BasicValueTypes()
		{
			// assign a value

			string LastName = "Doe";
			nameString = "Hello World2";
			string fullname = FirstName + "\n " + LastName;
			//concatenate 
			string concat = $"{FirstName} and {LastName}";

			Console.WriteLine(concat);
			string mystring = "JohnDoe";
			//string mystring =Console.ReadLine();
			Console.WriteLine(mystring.Length);
			Console.WriteLine(mystring[0]);
			char[] chars = mystring.ToCharArray();
		}
	}
}
