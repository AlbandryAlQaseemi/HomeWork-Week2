
using System;
class program
{

	static void checkNumber(string s)
	{
		int Leftsum = 0;
		int Rightsum = 0;

		for (int i = 0; i < s.Length / 2; i++)
		{

			Leftsum += (int)(Char.GetNumericValue(s[i]) -
							Char.GetNumericValue('0'));
			Rightsum += (int)(Char.GetNumericValue(s[s.Length -
													1 - i]) -
							Char.GetNumericValue('0'));
		}

		if (Leftsum == Rightsum)
			Console.WriteLine("true");
		else
			Console.WriteLine("false");
	}

	static void Main()
	{
		string s = "78987";

		checkNumber(s);
	}
