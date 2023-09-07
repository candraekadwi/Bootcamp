namespace Day4_Project1;

public class Rabbit:Animal
{
	private string _name;
	private int _age;
	public Rabbit(string name, int age)
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
        Console.WriteLine("Rabbit is Alive");
    }
}
