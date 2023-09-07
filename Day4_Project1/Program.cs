using myExtensionMethod;
using Day4_Project1;
class Program
{
	static void Main()
	{
		Cat cat = new Cat("cibi", 3);
		cat.Name().printf();
		cat.Age().printfint();
		cat.Info();
		cat.Desc();
	
		Console.WriteLine("");
		
		Rabbit rabbit = new Rabbit("abc", 6);
		rabbit.Name().printf();
		rabbit.Age().printfint();
		rabbit.Info();
		rabbit.Desc();
		rabbit.Info();
		
		Console.WriteLine("");
		cat.Name().printf();
		cat.Age().printfint();
		cat.Info();
		cat.Desc();
	
		
	}
}