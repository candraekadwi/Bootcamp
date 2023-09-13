
using Day7_Project2;

public delegate int MyDelegate(int a, int b);

class Program
{
	static void Main()
	{
		MyDelegate proses = Calculator.Sum;
		
		proses +=Calculator.Multiplay;
		
		Delegate[] data = proses.GetInvocationList();
		
		List<int> result=new();
		
		foreach(MyDelegate x in data)
		{
			result.Add(x.Invoke(4,7));
		}
		foreach(int i in result)
		{
			Console.WriteLine(i);
		}
	}
}