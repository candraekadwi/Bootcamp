namespace Hewan;

public class Cat
{
	public string? name;
	public string color;
	public int age;
	
	public bool isStrip;
	
	public Cat(string name, string color, int age)
	{
		this.name = name;
		this.color = color;
		this.age = age;
	}
	
	public Cat()
	{
		
	}
	public void Meow()
	{
		Console.WriteLine("Meowww");
	}
	public void Meow(string sound)
	{
		Console.WriteLine(sound);
	}
	public bool Meow( int time)
	{
		if(time > 0){
		Console.WriteLine("Meow" + time+"times");
		return true;
		}
		return false;
	}

}
