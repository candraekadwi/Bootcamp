namespace Day4_Project1;

public class Rabbit:Animal
{
	public string name;
	public int age;
	public Rabbit(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
	
	public override string Name()
	{
		return name;
	}
	public override int Age()
	{
		return age;
	}
    public override void Info()
    {
        Console.WriteLine("Rabbit is Alive");
    }
}
