namespace Operators
{
	class Operators_Notes
	{
		static void Main(string[] args)
		{//Operators 
			// Assignment operator: int x = 5
			
			// Arithmetic Operators: 

			//int addition = 5 + 5;
			//int subtraction = 7 - 5;
			//int multiplication = 9 * 5;
			//int division = 10 / 5;
			//int modulus = 6 % 5; // remainder after division, good for checking if a number is even or odd
			
			//bool isEven = 4 % 2  == 0;  // (==) is the comparison operator is 2 == 2
			//bool isEven = 5 % 2 == 0; // If you need a decimal
			
			//Unary Operators
			int x = 3; 
			int y = ++x; //PreIncrement 
			Console.WriteLine(x); // Output 4 
			Console.WriteLine(y); // Output 4 

			int a = 3; //
			int b = a++; //post increment  
			Console.WriteLine(a); // Output 4 
			Console.WriteLine(b); // Output 3 

			int c = 5; // pre decrement 
			Console.WriteLine(--c); // Output 4 
			
			int  d = 5; //post decrement 
			Console.WriteLine(d--); // Output 5 
			Console.WriteLine(d); // Output 4 
			
			//Relational Operators 

			bool isEqual = 7 == 7; //Output True because they are equal
			bool isNotEqual = 7 != 7; //Output False because they are equal 
			bool isGreaterThan = 7 > 9; //Output False because 7 is not greater than 9  
			bool isLessThan = 7 < 9; //Output True because 7 is less than 9
			bool isGreaterThanOrEqual = 7 >= 9; //Output False 
			bool isLessThanOrEqual = 7 <= 9; //Output True 
			
			//Logical Operators 

			bool resultOne = 7 == 7 && 6 == 6; //Outout True they both have to be True 
			bool resultTwo = 7 == 7 || 5 == 9; //Output True only one has to be True for the statement to be True 
			
			//Null coalescing operator 

			int? possibleNullValue = null;
			int notNullValue = possibleNullValue ?? 500; //double ?? gives it a value to default to 
			Console.WriteLine(notNullValue); //Returns 500 








		}
	}
};


