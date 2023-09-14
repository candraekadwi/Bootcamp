namespace Day8_Project1;

public class Proses
{
	public static EventHandler<DataArgs> ProsesHandler;
	
	public void ProsesData(string name, int age)
	{
		DataArgs args = new DataArgs();
		args.name = name;
		args.age = age;
		
		ProsesHandler.Invoke(this, args);
	}
}
