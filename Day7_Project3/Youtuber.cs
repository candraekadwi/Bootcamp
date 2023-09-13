namespace Day8_Project3;

public class Youtuber
{
	public EventHandler<EventData> subscriber;
	private string _name;
	
	public Youtuber(string name)
	{
		_name = name;
	}
	public void UploudVideo()
	{
		Console.WriteLine("Uplouding Vidio...");
		SendNotification();
	}
	public void SendNotification()
	{
		if(subscriber != null)
		{
			subscriber.Invoke(this, new EventData{id = 1, message = "Uploud Vidio"});
		}
	}
	public void EventClear()
	{
		subscriber = null;
	}
    public override string ToString()
    {
        return _name;
    }
}

