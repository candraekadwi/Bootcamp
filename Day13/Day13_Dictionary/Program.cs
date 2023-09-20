class Program
{
	static void Main()
	{
		//Dictionary
		
		Dictionary<int,string> dict = new Dictionary<int, string>();
		
		dict.Add(2, "wow");
		dict.Add(7,"ass");
		dict.Add(3,"fofo");
		foreach(var x in dict)
		{
			Console.WriteLine($"key {x.Key}, value {x.Value}");
		}
		Console.WriteLine("");
		dict.TryAdd(2,"faku");
		dict[3]="bebe";
		dict.Remove(7);
		foreach(var x in dict)
		{
			Console.WriteLine($"key {x.Key}, value {x.Value}");
		}
		bool haha=dict.TryGetValue(3,out string y);
		Console.WriteLine(haha);
		Console.WriteLine(y);
	}
}