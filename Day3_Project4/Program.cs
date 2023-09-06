using Day3_Project4;
using Day3_Project4.Part;

class Program
{
	static void Main()
	{
		
		// Animal animal2 = new Animal();
		// Cat cat2 = (Cat) animal2;
		// cat2.MakeSound();
		// cat2.jump();
		// cat2.Eat();
		
		// Harus dari Child > Parent > Child
		
		Cat save = new Cat();
		Animal animal = save;
		Cat cat1 = (Cat)animal;
		
		Console.WriteLine("");
		save.MakeSound();
		 save.jump();
		 save.Eat();
		 Console.WriteLine("");
		 animal.MakeSound();
		 //animal.jump(); animal ga ada jump
		 animal.Eat();
		 Console.WriteLine("");
		cat1.MakeSound();
		 cat1.jump();
		 cat1.Eat();
	}
}