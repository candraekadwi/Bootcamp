
using Day38_DesignPatterns_Observer;

class Program
{
	static void Main()
	{
		Publisher pub = new Publisher();
		Subscriber sub1 = new Subscriber("rudi");
		Subscriber sub2 = new Subscriber("budi");
		Subscriber sub3 = new Subscriber("jhon");
		
		pub.Add(sub1);
		pub.Add(sub2);
		pub.Add(sub3);
		pub.Massage = "hallo guys";
		pub.Remove(sub2);
		pub.Massage = "hallo Bro";
		
		
		
	}
}