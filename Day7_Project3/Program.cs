using Day8_Project3;

class Program
{
	static void Main()
	{
		Youtuber yt = new ("Aji");
		Youtuber yt2 = new("Budi");
		
		Subscriber sub1 = new Subscriber();
		Subscriber2 sub2 = new Subscriber2();
		
		yt.subscriber +=sub1.Notification;
		yt2.subscriber -= sub2.Notification;
		
		yt.UploudVideo();
		
		yt2.subscriber +=sub2.Notification;
		yt2.UploudVideo();
		yt.EventClear();
	}
}