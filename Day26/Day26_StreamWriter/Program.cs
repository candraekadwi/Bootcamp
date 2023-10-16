class Program
{
	static void Main()
	{
		using (FileStream fs = new(@"./haha.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
		{
			using (StreamWriter sw = new StreamWriter(fs))
			{
				var mystring = File.ReadAllLines(@"./haha.txt").ToList();
				string x = "awalan";
				var newstring = x + mystring;
				sw.WriteLine(newstring);

			}
		}
	}
}