namespace Day4_Project1;

public class Cat:Animal
{
	private string _name;
	public int _age;
	public Cat(string name, int age )
	{
		this._name = name;
		this._age = age;
	}
	
	public override string Name()
	{
		return _name;
	}
	public override int Age()
	{
		return _age;
	}

    public override void Info()
    {
        Console.WriteLine("Cat Is Alive");
    }


}
