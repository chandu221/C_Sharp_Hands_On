using System;

public struct Pair<T,U> //Question 2.1
	{
		public readonly T Fst;
		public readonly U Snd;
		public Pair(T fst, U snd) 
		{
			this.Fst = fst;
			this.Snd = snd;
		}
		public override String ToString() 
		{
			return "(" + Fst + ", " + Snd + ")";
		}
		public Pair<U,T> Swap()
		{
			return new Pair<U,T>(Snd,Fst);
		}
	}
public class Program
{
	public static void Main()
	{
		//example 1
		//var p1 = new Pair<string,int>("Anders",13); 
		//var p1 = new Pair<string,double>("Phoenix",39.7);
		//var p1 = new Pair<string,double>("Pip",11); //int fits in double
		//Console.Write(p1.ToString());
		
		//example 2
		/*var grades = new Pair<string,int>[]
		{
			new Pair<string,int>("Andres",13),
			new Pair<string,int>("Phoenix",33),
			new Pair<string,int>("pip",11),	
		};
		for (int i = 0; i < grades.Length; i++) 
		{ 
			if (grades[i].ToString() != null) 
				Console.WriteLine($"{grades[i].ToString()}"); 
		}*/
		
		//example 3 use on its own type
		//var period = new Pair<int,int>(11,12);
		//var appointment = new Pair<Pair<int,int>,string>(period,"bob");
		//Console.WriteLine(appointment.ToString()); //appointment.fst.snd => int type
		
		//example 4 Swap Function
		//var period = new Pair<int,string>(11,"Eleven");
		//Console.Write(period.Swap());
		
		

	}
	

}
