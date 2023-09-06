using Day3_Project3;
using Day3_Project3.Part;
class Program
{
	static void Main()
	{
	PistonEngine engine= new PistonEngine();
	engine.EngineRun();
	ElectricEngine electric = new ElectricEngine();
	IEngine engines = electric;
	IElectric electrics = electric;
	IElectricEngine engineElectric = electric;
	engines.EngineRun();
	electrics.Charge();
	engineElectric.EngineRun();
	engineElectric.Charge();
	}
}