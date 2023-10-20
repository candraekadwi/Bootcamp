
using System.Text.Json;
using Day27_JsonSerailization;

class Program
{
	static void Main()
	{
		Car car = new Car();
		car.year=3;
		car.brand ="toyota";
		string serialization = JsonSerializer.Serialize(car);
		using (StreamWriter fs = new StreamWriter(@"C:/text2.json"))
	{
		fs.Write(serialization);
	}

	Car result;
	using (StreamReader fs = new StreamReader(@"C:/text2.json"))
	{
		string resultJson = fs.ReadToEnd();
		result = JsonSerializer.Deserialize<Car>(resultJson);
	}
	Console.WriteLine(result.year);
	Console.WriteLine(result.brand);
	}
}