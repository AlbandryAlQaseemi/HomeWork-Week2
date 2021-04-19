
using System;
using System.Collections.Generic;


public class Numbers
{
	
	public static bool checkNumber(string str)
	{
		Stack<char> stack = new Stack<char>();

		stack.Push(str[0]);

		for (int i = 1; i < str.Length; i++)
		{
			if (stack.Peek() == str[i])
				stack.Pop();
			else
				stack.Push(str[i]);
		}
		if(stack.Count == 0)
        {
			return true;
        }
		return false;
	}

	public static void Main()
	{
		string[] arr = { "1234455321", "89339989", "893398" };
		foreach (string str in arr)
		{
			Console.WriteLine(str + " --> " + checkNumber(str));
		}
	}

}
