namespace Day4_Project1;

public class Cat:Animal
{
	public string name;
	public int age;
	public Cat(string name, int age )
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
        Console.WriteLine("Cat Is Alive");
    }


}
