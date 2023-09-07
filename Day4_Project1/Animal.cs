namespace Day4_Project1;


public abstract class Animal
{
	
 
	public static void Desc()
	{
		Console.WriteLine("From Animal");
	}
	
	public void Data()
	{
		Console.WriteLine("DATA form Animal");
	}
	public abstract void Info();
	public abstract string Name();
	
	public abstract int Age();
}
