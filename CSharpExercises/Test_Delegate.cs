using System;

public delegate void IntAction(int x);

public class Program
{
	
	static void PrintInt(int x){ Console.WriteLine(x);}
	
	static void Perform(IntAction act, params int[] arr) //params array is for any number of arguments 
	{ 
		foreach(var i in arr) act(i);
	}
	
	public static void Main()
	{
		IntAction Act = PrintInt;
		Act(42);
		//int[] testarr = {1,2,3,4,5,6};
		//Perform(PrintInt,testarr);
		Perform(PrintInt,1,2,3,4,5,6);
		
	}
}
