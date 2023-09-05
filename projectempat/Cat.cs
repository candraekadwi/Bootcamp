namespace Point;

public class Cat : Data
{
	public Cat(string name, int age) : base(name, age)
	{
		_name =name;
		_age=age;
		balance = 2;
	}
	public void SetBalances(int number) {
		balances = number;
	}

}
