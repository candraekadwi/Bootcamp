using Day3_Project5;

class Program
{
	static void Main()
	{
		Animal animal1 = new Animal("cat", 3);
		Console.WriteLine(animal1.GetName());
		Console.WriteLine(animal1.GetAge());
		Console.WriteLine("");
		
		Animal animal2 = new Animal("Rabbit", 5);
		Console.WriteLine(animal1.GetName());
		Console.WriteLine(animal1.GetAge());
		Console.WriteLine(animal2.GetName());
		Console.WriteLine(animal2.GetAge());
		
		
	}

}