namespace Day8_Project3;

public class Subscriber
{
	public void Notification(object sender, EventData e)
	{
		Console.WriteLine($"{e.id} from Youtuber {sender}");
	}
}
