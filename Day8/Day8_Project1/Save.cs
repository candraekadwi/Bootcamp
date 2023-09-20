using System.Collections;

namespace Day8_Project1;

public class Save
{
	Dictionary<string, int> simpan = new Dictionary<string, int>();
	public void SaveDB(object sender, DataArgs x)
	{
		try
		{
			simpan.Add(x.name, x.age);
		}
		catch (Exception e)
		{
			
			Console.WriteLine(e.Message);
		}
		
	}

	public void ShowData()
	{
		Console.WriteLine("\n Show Data...");
		// IEnumerator iterator = simpan.GetEnumerator();
		// while (iterator.MoveNext())
		// {
		// 	Console.WriteLine(iterator.Current);
		// }
		foreach (KeyValuePair<string, int> x in simpan)
		{
			Console.WriteLine($"Name: {x.Key} , Age: {x.Value} ");
		}
	}


}
