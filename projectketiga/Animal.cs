namespace Hewan;

using Hewan.Part;
public class Animal
{
	public string name;
	public string age;
	
	public Animal(string name)
	{
		Console.WriteLine($"Animal {name} Created");
	}
	public void Eat()
	{
		Console.WriteLine("Eat");
	}
	
}
