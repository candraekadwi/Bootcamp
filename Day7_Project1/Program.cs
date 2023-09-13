using Day7_Project1;

public delegate void MyDelegate(string x);
class Program
{
	static void Main()
	{
		Cat cat = new();
		MakeSound makeSound=new();
		
		cat.AddSound(makeSound.Out);
		cat.AddSound(makeSound.Out);
		cat.Sound();
		
		cat.RemoveSound(makeSound.Out);
		cat.Sound();
	}
}