using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
	internal class FloatNdDecimal
	{
		//declare 
		float myFloat = 5.5f;
		double myDouble = 5.5;

		float myFloat2 = 10.5f;
		double myDouble2 = 15.5;

		public FloatNdDecimal()
		{
			FloatingNumber();
			DoubleNumber();


		}

		public void FloatingNumber()
		{
			Console.WriteLine("Float Valriables 32bit  \n");
			float sum = myFloat + myFloat2;
			float difference = myFloat - myFloat2;
			float product = myFloat * myFloat2;
			float qoutient = 15.5f / myFloat2;

			Console.WriteLine($"{myFloat} + {myFloat2}={sum}");
			Console.WriteLine($"{myFloat} - {myFloat2}={difference}");
			Console.WriteLine($"{myFloat} * {myFloat2}={product}");
			Console.WriteLine($"{myFloat} / {myFloat2}={qoutient}");

		}

		public void DoubleNumber()
		{

			Console.WriteLine("Double Valriables \n");
			double sum = myDouble + myDouble2;
			double difference = myDouble - myDouble2;
			double product = myDouble * myDouble2;
			double qoutient = 15.5 / myDouble2;

			Console.WriteLine($"{myDouble} + {myDouble2}={sum}");
			Console.WriteLine($"{myDouble} - {myDouble2}={difference}");
			Console.WriteLine($"{myDouble} * {myDouble2}={product}");
			Console.WriteLine($"{myDouble} / {myDouble2}={qoutient}");

		}
	}
}
