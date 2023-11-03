using Day38_WithOut_Observer;

class Program
{
	static void Main()
	{
		Publisher pub= new Publisher();
		Subscriber sub1 = new Subscriber("rudi");
		Subscriber sub2 = new Subscriber("budi");
		Subscriber sub3 = new Subscriber("jhon");
		
		string message = "halo";
		pub.Notify(sub1, message);
		pub.Notify(sub2, message);
		pub.Notify(sub3, message);
	}
}