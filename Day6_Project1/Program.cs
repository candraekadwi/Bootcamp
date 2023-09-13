using Day6_Project1;

class Program
{
	static void Main()
	{
		Youtuber yt = new("Aji");
		Subcriber sub1 = new Subcriber();
		Subcriber2 sub2 = new Subcriber2();
		
		yt.subscriber += sub1.Notificaton;
		yt.subscriber -=sub2.Notificaton;
		
		yt.UplodVideo();
		yt.EventClear();
	}
}