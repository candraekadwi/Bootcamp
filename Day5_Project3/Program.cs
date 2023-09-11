
class Program
{
	static void Main()
	{ Hewan[] a = (Hewan[])Enum.GetValues(typeof(Hewan));
		foreach(var b in a)
		{
			Console.WriteLine($"{b.ToString()} index : {(int)b}");
			
		}
		string[] c = Enum.GetNames(typeof(Hewan));
		foreach(var d in c)
		{
			Console.WriteLine(d);
		}
	}
	
}
public enum Hewan
	{
		Ayam = 1,
		Kelinci,
		Ikan,
		Kucing,
		Sapi
		
	}