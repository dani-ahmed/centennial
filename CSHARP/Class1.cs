using System;

public class Class1
{
	public Class1()
	{
		static public void Main(String[] args)
        {
			//Write a program to prompt the user to enter 
			//a single character. The program should display a
			//message like “Your response was y”. For this question,
			//you must use a variable of type char

			Console.Write("Enter a single character");
			char c = Console.Read();
			Console.WriteLine("Your response was ");
			Console.WriteLine(c);
        }
	}
}
