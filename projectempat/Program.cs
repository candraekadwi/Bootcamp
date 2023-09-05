using Point;

class Program
{
	static void Main()
	{
		Cat cat = new Cat("cibi", 5);
		Console.WriteLine(cat.GetName());
		Console.WriteLine(cat.Getage());

		cat.balance = 2;
		Console.WriteLine(cat.balance);

		cat.SetBalances(2);

	}
}
