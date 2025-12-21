namespace Variable_lecture;

class Program

{
	static void Main(string[] args)
	{//Number types
  //Declaring a variable
  //camelCase for variable
  int wholeNumber; 
  
  //Initializing a variable (giving a variable a value)

  wholeNumber = 5;
  Console.WriteLine(wholeNumber);
  
  //Declaring and Initializing 

  int newNumber = 10;

  double average = 99.80; //Double is used for more precise math. 

  decimal currency = 1000.00m; //mainly used at banks most potential out of math uses more memory
  
  //Word Types 
  string ourClass = "CSharp";

  char initial = 'Z';
  
  //Fact Type
  
  bool isCoding = true; //just true or false no quotation 
  
  //String Interpolation (Calling another variable inside a string)
  string ourMessage = $"Our Class is {ourClass}"; //$ same as f-string in Python Created a variable 
  //Console.WriteLine($"Hello {ourClass}");//Write directly without creating a variable. 
  
  //Take user input
  
  Console.WriteLine("Give me your name:");
  
  
  string userName = Console.ReadLine(); //Methods that do something for us.
	}
}