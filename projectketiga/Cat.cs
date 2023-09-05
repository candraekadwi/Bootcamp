namespace Hewan.Part;

public class Cat : Animal
{
	public Cat(string name) : base(name)
	{
		Console.WriteLine($"Cat {name} Created");
	}
	public void Meow()
	{
		Console.WriteLine("Meow");
	}
}
