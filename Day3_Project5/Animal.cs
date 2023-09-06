namespace Day3_Project5;

public class Animal
{
	public static string _name;
	
	public int age;
	
	public Animal(string name, int age)
	{
		_name=name;
		this.age = age;
	}
	public static void Eat()
	{
		Console.WriteLine("Animal Eat");
		Console.WriteLine(_name);
		//Console.WriteLine(age); tidak bisa karena non static
	}
	
	public string GetName()
	{
		return _name;
	}
	public int GetAge()
	{
		return age;
	}
	
	
}
