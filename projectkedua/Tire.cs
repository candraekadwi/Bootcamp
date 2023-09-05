namespace Mobil.Part;

public interface ITire
{
	void TireMerk();
}
class Merk1 : ITire
{
		public void TireMerk(){
		Console.WriteLine("bridgestone");
		}
}
class Merk2 : ITire
{
		public void TireMerk(){
		Console.WriteLine("roda1");
		}
	}
	class Merk3 : ITire
	{
		public void TireMerk(){
		Console.WriteLine("roda2");
		}
	}
