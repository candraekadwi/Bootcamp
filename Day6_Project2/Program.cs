using Day6_Project2;

class Program
{
	static void Main()
	{
		List<IHewan> data = new List<IHewan>();
		data.Add(new Cat());
		data.Add(new Bird());
		//data.Add(new Fish());
		data[0].Sound();
		data[1].Sound();
		
		
		Dictionary<int,string>dict = new();
		dict.Add(0,"2");
		dict.Add(1, "10");
	}
}