namespace Day38_DesignPatterns_Observer;

public interface IPublisher
{
	public void Add(ISubscriber subscriber);
	public void Remove(ISubscriber subscriber);
	public void Notify();
}
