using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{ //--variubles--
			long numb1;
			string operation;
			long numb2;
		 //--MAIN CODE--
			Console.WriteLine("What is the operation");
			operation = Console.ReadLine();
			Console.WriteLine("What is the First number?");
			numb1 = Convert.ToInt64(Console.ReadLine());
			Console.WriteLine("What is the second number?");
			numb2 = Convert.ToInt64(Console.ReadLine());
			Console.WriteLine("The answer is down below");
			if(operation == "add") { Console.WriteLine(numb1 + numb2); }
			else if(operation == "sub") { Console.WriteLine(numb1 - numb2); } 
			else if (operation == "mul") { Console.WriteLine(numb1 * numb2); }
			else if (operation == "div") { 
				Console.WriteLine(numb1 / numb2);
				System.Threading.Thread.Sleep(500);
				Console.WriteLine("and  remainder");
				Console.WriteLine(numb1 % numb2);
			}
			System.Threading.Thread.Sleep(5000);
			for(; ; ) { }
		}
	}
}