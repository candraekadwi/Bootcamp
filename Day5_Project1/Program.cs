using System.Reflection;

class Program
{
	static void Main()
	{
		var x = 3;
		var y = "haha"; 
		Car car = new Car("toyota");
		
		Console.WriteLine("x cek");
		x.cek();
		Console.WriteLine("y cek");
		y.cek();
		Console.WriteLine("a cek");
		car.cek();
		
		Console.WriteLine("form add");
		Add(car);
		//Console.WriteLine(car);
		
	}
	static void Add(Car car1)
	{
	car1.data ="subaru";
	Console.WriteLine(car1.data);
	}
}


class Car
{
	public string data;
	public Car(string x){
	data = x;
	}
}

public static class myExtensionMethod{
	public static void cek(this object x)
	{
		if(x is int)
		{
			Console.WriteLine($"{x} is a int");
		}
		if (x is ValueType)
		{
			Console.WriteLine($"{x} is Value Type");
		}
		if (!(x is ValueType))
		{
			Console.WriteLine("is a reference");
		}
		if(x is null)
		{
			Console.WriteLine($"{x } is null");
		}
		else if (x.GetType().GetTypeInfo().IsClass) {
			Console.WriteLine("value is reference type");
		}
	}
}
