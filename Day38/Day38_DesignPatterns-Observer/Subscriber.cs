namespace Day38_DesignPatterns_Observer;

public class Subscriber : ISubscriber
{
	private string _name;
	public Subscriber(string name)
	{
		_name=name;
	}
	public void Update(Publisher publisher)
	{
		Console.WriteLine($"New notification for {_name}, Message = {publisher.Massage}");
	}

}
