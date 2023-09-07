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
		Animal.Desc();
	
		Console.WriteLine("");
		
		Rabbit rabbit = new Rabbit("abc", 6);
		rabbit.Name().printf();
		rabbit.Age().printfint();
		rabbit.Info();
		Animal.Desc();
		rabbit.Info();
		
		Console.WriteLine("");
		cat.Name().printf();
		cat.Age().printfint();
		cat.Info();
		Animal.Desc();
		
		Console.WriteLine("");
		Animal animal = rabbit;
		animal.Name().printf();
		animal.Age().printfint();
		animal.Info();
		Animal.Desc();
		//animal.Desc(); error karena diset static
		animal.Data();
		//Animal.Data(); error karena abstrack sehingga tidak bsia di akses
	
		
	}
}