namespace Day38_WithOut_Observer;

public class Publisher
{
	public void Notify(Subscriber subcriber, string message)
	{
		Console.WriteLine($"New notification for {subcriber.Name}, Message = {message}");
	}
}
