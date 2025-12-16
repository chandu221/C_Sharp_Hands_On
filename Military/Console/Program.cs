using MilitaryApp.Domain;
using MilitaryApp.Data;
class Program
{
    static MilitaryContext context = new MilitaryContext();

    static void Main(string[] args) 
    {
        context.Database.EnsureCreated();

        GetMilitary("Before Add: ");

        AddMilitary();

        GetMilitary("After Add: ");
    }

    private static void GetMilitary(string text) 
    {
        var militarys = context.Militaries.ToList();

        Console.WriteLine($"{text}: Military Count is {militarys.Count}");

        foreach (var military in militarys)

            Console.WriteLine(military.Name);
    }

    private static void AddMilitary() 
    {
        var militarys = new Military { Name = "Anit" };

        context.Militaries.Add(militarys);

        context.SaveChanges();
    }


}

