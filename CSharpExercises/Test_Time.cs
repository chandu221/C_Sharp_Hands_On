using System;
					
public class Program
{
	public static void Main()
	{
		Time t1 = new Time(0,45);
		Time t2 = new Time(10,05);
		total minutes or hhmm format  
		Console.WriteLine($0045 = {t1} & 1005 ={t2});
				
		Time t3 = new Time(9,30);
		Console.WriteLine(t3 + new Time(1, 15));
		Console.WriteLine(t3 - new Time(1, 15));
		
		Time t1 = new Time(9, 30);
        Time t2 = 120;   int - time
        int m1 = (int)t1; time - int

        Console.WriteLine($t1={t1} and t2={t2} and m1={m1});

        Time t3 = t1 + 45; 

        Console.WriteLine(t3 =  + t3);
		
	}

	public struct Time 
	{ 
		private readonly int minutes; 

		public Time(int hh, int mm) 
		{
			this.minutes = 60  hh + mm; 
		} 
		public Time(int totalminutes)
		{
			this.minutes = totalminutes;
		}
		
		private readonly int Hour{get {return minutes60;}}
		private readonly int Minute{get {return minutes%60;}}
		
		public override String ToString() 
		{
			return minutes.ToString(); Question 1.1
			return String.Format(${Hour}{Minute}); Question 1.2
		}
		
		Question 1.3 (+,-)
		public static Time operator +(Time t1,Time t2)
		{
			return new Time(t1.minutes + t2.minutes);
		}
		public static Time operator -(Time t1,Time t2)
		{
			return new Time(t1.minutes - t2.minutes);
		}
		Question 1.4 implicit and explicit
		
		int - time
		public static implicit operator Time(int m)
		{
			return new Time(m);
		}
		time - int
		public static explicit operator int(Time t)
		{
			return t.minutes;
		}	
		Question 1.5 
		Struct is value type and Class is reference type so non-static fields are illegal in Struct. If we can use a static field of it's also legal to run
		Question 1.6
		Struct Copies the whole value(independent values) but Class Copies only the referof the object(Shares the object).
	}
}