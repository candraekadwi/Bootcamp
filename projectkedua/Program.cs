using Mobil;

using Mobil.Part;
class Program
{
	public static void Main()
	{
		Engine toyota = new Engine("toyota","v6", "gasoline");
		Console.WriteLine(toyota.engine);
		
		Merk1 ban1 = new Merk1();
		Merk2 ban2 = new Merk2();
		
		Car ban = new Car(ban1);
		
		ban.Tiredigunakan();
	}
}

