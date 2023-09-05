using Hewan;

class Program
{
	static void Main()
	{
		Cat cibi = new Cat("sibi", "red", 3);
		Console.WriteLine(cibi.name);
		Cat burhan = new Cat("burhan", "blue", 4);
		
		Cat susi = new Cat();
		
		cibi.Meow();
		cibi.Meow("arrrhhg");
		cibi.Meow(3);
		
		
	}
}