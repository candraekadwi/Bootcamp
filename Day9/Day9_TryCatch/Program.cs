
class Program
{
	static void Main()
	{
		
			//IndexOutOfRange Exception
			//int[] arrayInt = {1,2,3};
			//int x = arrayInt[3];
			
			//DividedByZero Exception
			//int a = 10;
			//int b = 0;
			//int c = a/b;
			
			//StackOverFlow Exception
			//Caller();
			
			//NullReference Exception
			//string a = null;
			//a.Trim();
			
			//RuntimeBinder Exception
			//dynamic  x = "string";
			//x.EngineRun();
			
		string a = "20c";
		try
		{
			int x = int.Parse(a);
			Console.WriteLine(x);
		}
		catch (Exception e)
		{
			
			Console.WriteLine($"{e.Message} ERRORR");
			
		}
		finally
		{
			Console.WriteLine("Adapun yang terjadi gasss..");
		}
		Console.WriteLine("Finnised");
	}
}