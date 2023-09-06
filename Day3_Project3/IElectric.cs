namespace Day3_Project3.Part;

public interface IElectric
{
	void Charge();
}
public class ElectricEngine : IElectricEngine
{
	public void EngineRun() {
		Console.WriteLine("Electric");
	}
	public void Charge() 
	{
		Console.WriteLine("Charging...");
	}
}
