namespace Day3_Project3;
using Day3_Project3.Part;
public interface IEngine 
{
	void EngineRun();
}

public interface IElectricEngine : IEngine, IElectric
{
}
public class PistonEngine : IEngine {
	public void EngineRun() {
		Console.WriteLine("Piston");
	}
}
public class DieselEngine : IEngine {
	public void EngineRun() {
		Console.WriteLine("Diesel");
	}
}

public class Jet : IEngine
{
	public void EngineRun() {
		Console.WriteLine("Electric");
	}
}