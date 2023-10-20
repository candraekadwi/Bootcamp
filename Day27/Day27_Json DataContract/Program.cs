
using System.Runtime.Serialization.Json;
using Day27_Json_DataContract;

class Program
{
	static void Main()
	{
		Car car = new Car();
		car.year = 4;
		car.brand = "totoya2";
		var serializer = new DataContractJsonSerializer(typeof(Car));
		using (FileStream fs = new FileStream(@"C:/text2.json", FileMode.Create))
		{
			serializer.WriteObject(fs, car);
		}

		Car result;
		using (FileStream fs = new FileStream(@"C:/text2.json", FileMode.Open))
		{
			result = (Car)serializer.ReadObject(fs);
		}
		Console.WriteLine(result.year);
		Console.WriteLine(result.brand);
	}
}