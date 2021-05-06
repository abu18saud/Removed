using System;
using System.Collections.Generic;

namespace Removed
{
    class Program
    {
        static void Main(string[] args)
        {
			Stack<int> evenNums = new Stack<int>();

			evenNums.Push(4);
			evenNums.Push(8);
			evenNums.Push(6);

			int num = Convert.ToInt32(Console.ReadLine());

			evenNums.Push(num);

			Console.WriteLine("Checking the last number: " + num);

			// your code goes here
			if(num % 2 != 0)
            {
				Console.Write(evenNums.Pop()+ ": Removed");
			}

			foreach (int i in evenNums)
				Console.Write(i + " ");

			/*
			Stack<int> s = new Stack<int>();
            
		    s.Push(59);
		    s.Push(72);
		    s.Push(65);

		    Console.Write("Stack: ");
		    foreach (int i in s)
		        Console.Write(i + " ");  // 65  72  59
		    Console.Write("\nCount: " + s.Count);  // 3
            
		    Console.Write("\nTop: " + s.Peek());  // 65
		    Console.Write("\nPop: " + s.Pop());  // 65
            
		    Console.Write("\nStack: ");
		    foreach (int i in s)
		        Console.Write(i + " ");  // 72  59
		    Console.Write("\nCount: " + s.Count);  // 2
			 */
		}
	}
}
