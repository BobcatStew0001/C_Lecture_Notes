namespace MethodsDemoCSharp;

class Program
{
    //Method definition (creating a methods)
    //Disregard the keyword 'static'
    //Pascal casing-EveryWordStartsWithCapital
    //Parts of a method
    //Access modifier --> Return type --> Method name --> Parameter list --> Scope/Body (What the method does when used.)
    //Examples of Accesss Modifiers
    //Public, Private, Internal, & Protected. 
    public static void GreetPerson(string name)//Method
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static int AddTwoNums(int num1, int num2)//Method
    {
        //int sum = num1 + num2;
        //return sum; we could do it without storing it in a variable. 
        return num1 + num2;
    }

    public static void GetUserNameAndGreet()
    {
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!");
    }
    static void Main(string[] args)
    {// A method does a task for us. It has a job and does it for us. It saves times. 
        
        //Console.WriteLine("Hello World!");//WriteLine is an example and does a job for us. We don't need to make a 
        //variable to get the job done over and over again. //It is a void return type it does its job and nothing more

        //string response = Console.ReadLine();//Returns a string is a non void. //void cannot be used in a variable 
        //non-void can be used as in the example. 
        
        //You can make custom methods. Make sure you are not inside another method. Scope is inside the curly braces 
        //below the main and the class is curly braces below the Class Program. 



    //Calling a method(using a method)
    GreetPerson("Zach");
    GreetPerson("Seth");
    int sum = AddTwoNums(10, 20);
    Console.WriteLine(sum);
    Console.WriteLine(AddTwoNums(50, 20));
    
    GetUserNameAndGreet();



    }
}    
    

