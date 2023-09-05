namespace Mobil;

using Mobil.Part;
 class Car
{
	public Engine engine;
	public Engine fulltype;
	public string? lamp;
	
	public ITire tire;
	
	public Car(Engine engine, Engine fulltype, string? Lamp)
	{
		this.engine = engine;
		this.fulltype = fulltype;
		this.lamp = Lamp;
	}

	public Car(ITire tire)
	{
		this.tire = tire;
	}
	public void Tiredigunakan()
	{
		tire.TireMerk();
	}
	
}
