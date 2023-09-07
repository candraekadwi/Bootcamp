
using Day4_Project2;
using myExtensionMethod;
class Program
{
	static void Main()
	{
		int a = 2;
		int b=a;
		b =3;
		Console.WriteLine("Test 1");
		a.printfint();// out 2
		b.printfint();// out 3
		
		Console.WriteLine("");
		
		Console.WriteLine("Test 2");
		Cek cek1  = new Cek(9);
		Cek cek2 = cek1;
		cek2.price=2;
		cek1.price.printfint();// out 2
		cek2.price.printfint();// out 2

		Console.WriteLine("Test 3");
		Cek cek3 = cek1;
		Cek cek4 = cek3;
		cek4.price=5;
		cek1.price.printfint();// output 5
		cek2.price.printfint();// output 5
		cek3.price.printfint();// output 5
		cek4.price.printfint();// output 5
		
	}
}