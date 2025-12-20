using System;
using System.Collections.Generic;

public delegate void Action<T>(T value);
public class Program
{
	static void Perform<T>(Action<T> act, params T[] arr) 
	{ 
		foreach (T item in arr) { act(item); }
	}
	/*static int GreaterCount(List<double> list, double min) 
		{ 
			Console.WriteLine("Via List double");
			int count = 0;
			foreach(var t in list)
			{
				if(t>=min)
					count++;
			}
			return count;
		}
	static int GreaterCount(IEnumerable<double> eble, double min) 
		{
			Console.WriteLine("Via Emuerable double");
			int count = 0;
			foreach(var t in eble)
			{
				if(t>=min)
					count++;
			}
			return count;
		}
	static int GreaterCount(IEnumerable<string> eble, string min) 
		{
			Console.WriteLine("Via Emuerable string");
			int count = 0;
			foreach(var t in eble)
			{
				if(t.CompareTo(min)>=0)
					count++;
			}
			return count;
		}*/
	static int GreaterCount<T>(IEnumerable<T> eble, T x) where T : IComparable<T>
		{
			int count = 0;
			foreach(var t in eble)
			{
				if(t.CompareTo(x)>=0)
					count++;
			}
			return count;
		}
	
	public static void Main()
	{
		
			
		var temperatures = new List<double>();
		temperatures.Add(21.5); 
		temperatures.Add(25.0); 
		temperatures.Add(30.2); 
		temperatures.Add(18.7); 
		temperatures.Add(27.3);
		
		var StrTemperatures = new List<string> { "21.5", "25.0", "30.2","18.7", "27.3"};
		
		/*int count = 0;
		foreach(var t in temperatures)
		{
			if(t>=25)
				count++;
		}
		Console.WriteLine($"The Temperatures exceeding 25 are {count}");*/
		
		var result = GreaterCount(temperatures,25);//via list
		Console.WriteLine($"GreaterCount result:{result}");
		
		var res = GreaterCount((IEnumerable<double>)temperatures, 25.0);//via emuerable double
		Console.WriteLine($"GreaterCount result:{res}");
		
		var strres = GreaterCount(StrTemperatures, "25.0");//via emuerable string
		Console.WriteLine($"GreaterCount result:{strres}");
	}
	

}
