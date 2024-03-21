using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
	internal class BooleanOperator
	{
		bool isTrue;
		bool isFalse;
		public BooleanOperator()
		{

			isFalse = false;
			isTrue = true;

			//AND && operator
			bool trueAndFalse = true && false;
			bool trueAndTrue = true && true;
			bool FalseAndFalse = false && false;

			//Or || operator
			bool trueOrFalse = true || false;
			bool trueOrTrue = true || true;
			bool FalseOrFalse = false || false;

			//! not operator
			bool notTrue = ! true;
			bool notFalse = ! false;


		}
	}
}
