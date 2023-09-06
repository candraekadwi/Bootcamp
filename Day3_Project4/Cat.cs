namespace Day3_Project4.Part;

public class Cat : Animal
{
	public string ras = "himalayan";
	public override void MakeSound()
	{
		Console.WriteLine("Meow form Cat");
	}
	public void jump()
	{
		Console.WriteLine("Cat jump");
		
	}
	public new void Eat()
	{
		Console.WriteLine("Eat form Cat");	
	}
	
}
