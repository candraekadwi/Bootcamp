using System.Collections;
class Program
{
	static void Main()
	{
		List<int> x = new List<int>{1,2,3,4,5,6};
		foreach(int i in x)
		{
			Console.WriteLine(i);
		}
		
		
		IEnumerator iterator = x.GetEnumerator();
		while(iterator.MoveNext()) {
			Console.WriteLine(iterator.Current);
		}
	
		iterator.MoveNext();
		iterator.Reset();
		Console.WriteLine(iterator.Current);
	}
}