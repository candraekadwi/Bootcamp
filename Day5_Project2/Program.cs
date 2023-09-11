using System.Reflection.Metadata;

class Program
{
	static void Main()
	{
		var x = "Cat";
		var y = 200;
		var z = "30";
		bool z1 = int.TryParse(z, out int zout);// safety
		// int zresult = int.Parse(z)  ===> not sefety
		var z10 = 30;
		object z2 = z10;//boxing
		long z3 = (int)z2;//unboxing
		
		
		AddReff(ref x);
		Console.WriteLine(x);
		Console.WriteLine("");
		
		AddOut(out y);
		Console.WriteLine(y);
		Console.WriteLine("");
		
		AddOut(out int y1);
		Console.WriteLine(y1);
		Console.WriteLine("");
		
		AddIn(in zout);
		Console.WriteLine($" boolean {z1}, value {zout} form tryparse");
		Console.WriteLine($" {z3} form boxing unboxing");
		
		
	}
	
	static void AddReff(ref string a)
	{
		a = "ayam";
		Console.WriteLine($"{a} form Reff");
	}
	
	static void AddOut(out int b)
	{
		b=9;
		b=b+2;
		Console.WriteLine($"{b} form Out");
	}
	static void AddIn(in int c) // read only
	{	//c=c+2; tidak bisa
		int d = c+2;// bisa karena hanya mengambil variabel c tidak merubah valuenya
		Console.WriteLine($"{c} form in");
		Console.WriteLine($"{d} form c+2 in");
	}
}
