using Day3_Project2;
using Day3_Project2.Part;
class Program
{
	static void Main()
	{
	Cat cat = new Cat();
	Animal animal = cat;
	
	//Overriding
	cat.MakeSound(); //meow
	animal.MakeSound(); //meow
	
	//Method Hiding
	cat.Eat(); //Cat Eat
	animal.Eat(); 
	}
}