using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//single comment
/*
*Multiline comment
*/
namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//create 4 variables of different data types
			//string, int, double, float, character, boolean
			string name = "Kutlwano";
			int age = 21;
			double passMark = 89.4;
			float numf = 2.8f;
			char myChar = 'W';
			bool myBool = true;
			
			
			Console.WriteLine("Welcome to programming 2A Mr " + name + ", " + age);
		}
	}
}
