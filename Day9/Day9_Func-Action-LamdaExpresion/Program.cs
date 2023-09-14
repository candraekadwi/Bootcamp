class Program
{
	static void Main()
	{   
		//lamda expresion
		Console.WriteLine("\n Lamda Expression");
		Func<int,int,int> myint1 = (int a, int b) => a+b;
		Console.WriteLine(myint1.Invoke(3,8));
		
		Func<string> myFuncPrint = () => "Hellooo"+"World";
	Func<string> myFuncPrint2 = () => "!";
	Func<string> result = myFuncPrint + myFuncPrint2;
	
	Delegate[] dels = result.GetInvocationList();
	
	foreach(Func<string> x in dels) {
		Console.WriteLine(x.Invoke());
	}
	
	result = result - myFuncPrint2;
	dels = result.GetInvocationList();
	
	foreach (Func<string> x in dels)
	{
		Console.WriteLine(x.Invoke());
	}
		
		// Func
		Console.WriteLine("\n Func");
		Func<int, int, int> dat = Adder;
		Console.WriteLine(dat.Invoke(2,4));
		Func<string,string, int> dat2 = ToInt;
		Console.WriteLine(dat2.Invoke("2","4"));
		
		//Action
		Console.WriteLine("\n Action");
		Action<string> action = Printf;
		action += Printer;
		action.Invoke("name");
	
	}
	//Func
 static int Adder(int a, int b)
{
	return a+b;
}
 static int ToInt(string a, string b)
{
	bool z = int.TryParse(a, out int x);
	bool z1 = int.TryParse(b, out int y);
	return x+y;
}

//Action
 static void Printf(string x)
{
	Console.WriteLine(x);
}
 static void Printer(string y)
{
	Console.WriteLine($"{y} Burhan");
}
}

