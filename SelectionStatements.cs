using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			long newLong;
			int newInt;
			const double PI = 3.14;
			Console.WriteLine(PI);
			
			//if statements
			//if (condition){}
			if(PI == 3.14)
	    {
	      Console.WriteLine("Your number is the constant PI");
	    }
	    else
	    {
	      Console.WriteLine("Your number is not a constant");
	    }
	    
	    //if statements
	    Console.WriteLine("Enter the number that corresponds with the day of the week ");
	    int day = Convert.ToInt32(Console.ReadLine()); //converts input to integer
	    int day2 = int.Parse(Console.ReadLine());
	    
			
		}
	}
