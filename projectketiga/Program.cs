using Hewan;

using Hewan.Part;
class Program 
{
	static void Main()
	{
		
		Cat cat = new Cat("cibi");
		Console.WriteLine(cat.name);
		cat.Eat();
		cat.Meow();
		
		Animal animal = new Animal("ayam");
		Console.WriteLine(animal.name);
		animal.Eat();
	}
}