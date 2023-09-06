using Day3_Project1;
using Day3_Project1.Part;

class Program
{
	static void Main()
	{
		 Animal animal = new Animal();
		 animal.MakeSound();
		
		Cat cat = new Cat();
		cat.MakeSound();
		
		Animal cat2 = cat;
		cat2.MakeSound();
		
		Ant ant = new Ant();
		ant.MakeSound();
		
		
		
	}
}