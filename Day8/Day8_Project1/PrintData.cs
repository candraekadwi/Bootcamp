namespace Day8_Project1;

public class PrintData
{
	public void Print(object sender, DataArgs e)
	{
		Console.WriteLine("Data save to DB...");
		Console.WriteLine($"Name: {e.name} ");
		Console.WriteLine($"Age: {e.age} ");
	}
}
