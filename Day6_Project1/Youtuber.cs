using System.Security.Cryptography.X509Certificates;

namespace Day6_Project1;

public class Youtuber
{
	public delegate void myDelegate(string uploud);
	public event myDelegate subscriber;
	
	private string _name;
	
	public Youtuber(string name)
	{
		_name = name;
	}
	
	public void UplodVideo()
	{
		Console.WriteLine("Uplouding vidio...");
		if(subscriber !=null)
		{
			subscriber.Invoke(_name);
		}
		
	}
	public void EventClear()
	{
		subscriber =null;
	}
}
