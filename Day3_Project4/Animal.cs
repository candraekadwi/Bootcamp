namespace Day3_Project4;
using Day3_Project4.Part;
public class Animal
{
	public String name ="Cibi";
	public int age = 3;
	public virtual void MakeSound()
	{
		Console.WriteLine("Animla Sound");
	}
	public void Eat()
	{
		Console.WriteLine("Animal Eat");
	}
}
