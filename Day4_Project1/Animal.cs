namespace Day4_Project1;


public abstract class Animal
{
	public string name;
	public string age;
 
	public void Desc()
	{
		Console.WriteLine("From Animal");
	}
	public abstract void Info();
	public abstract string Name();
	
	public abstract int Age();
}
