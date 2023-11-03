namespace Day38_DesignPatterns_Observer;

public class Publisher : IPublisher
{
		private string _message = null!;
	private List<ISubscriber> _subscribers = new List<ISubscriber>();
	public void Add(ISubscriber subscriber)
	{
		_subscribers.Add(subscriber);
		Console.WriteLine("Success add new subscriber!");
	}
	

	public void Notify()
	{
		foreach (var sub in _subscribers)
		{
			sub.Update(this);
		}
		Console.WriteLine(" ");
	}

	public void Remove(ISubscriber subscriber)
	{
		_subscribers.Remove(subscriber);
		Console.WriteLine("Remove Subcriber From List!");
	}


	public string Massage
	{

		get { return _message; }
		set
		{
			_message = value;
			Notify();
		}

	}

}
