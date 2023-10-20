using System.Xml.Serialization;
using Day27_XmlSerialization;
class Program
{
	static void Main()
	{
		Car car = new Car();
		Car car2 = new Car();
		car.year = 4;
		car.brand = "totoya2";
		car2.year = 5;
		car2.brand = "mitsubishi";

		List<Car> cars = new();
		cars.Add(car);
		cars.Add(car2);

		var serializer = new XmlSerializer(typeof(List<Car>));
		using (StreamWriter fs = new StreamWriter(@"C:/text2.xml"))
		{
			serializer.Serialize(fs, cars);
		}

		List<Car> result;
		using (StreamReader fs = new StreamReader(@"C:/text2.xml"))
		{
			result = (List<Car>)serializer.Deserialize(fs);
		}
		foreach (Car c in result)
		{
			Console.WriteLine(c.year);
			Console.WriteLine(c.brand);
		}
	}
}