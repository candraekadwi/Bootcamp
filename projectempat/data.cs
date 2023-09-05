namespace Point;

public class Data
{
	protected string _name;
	protected int _age;
	
	public int balance;
	protected int balances{private get;set;}
	public Data(string name, int age)
	{
		_name = name;
		_age = age;
	}
	
	public string GetName()
	{
		return _name;
	}
	public int Getage()
	{
		return _age;
	}

}
