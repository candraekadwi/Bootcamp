using System.Data.SqlTypes;
using Day8_Project1;

class Program
{
	static void Main()
	{

		Save save = new Save();
		SendEmail sendEmail = new SendEmail();
		PrintData print = new PrintData();
		Proses proses = new Proses();

		Console.WriteLine("Command ....");
		Console.WriteLine("1. New : Add Name and Age");
		Console.WriteLine("2. Exit: Exit Program");
		Console.WriteLine("3. Show: Show Data");

		Proses.ProsesHandler += print.Print;
		Proses.ProsesHandler += save.SaveDB;
		Proses.ProsesHandler += sendEmail.Send;
		while (true)
		{
			Console.Write("\n Enter command : ");
			var com = Console.ReadLine();
			if (com.Equals("New"))
			{
				Console.WriteLine("\nEnter Data ....");
				Console.Write("name : ");
				var name = Console.ReadLine();
				Console.Write("\nAge : ");
				bool z = int.TryParse(Console.ReadLine(), out int age);
				Console.Write("\n Send to Email (y/n) : ");
				var notif = Console.ReadLine();

				if (notif.Equals("n"))
				{
					Proses.ProsesHandler -= sendEmail.Send;
				}

				proses.ProsesData(name, age);
			}
			else if (com.Equals("Show"))
			{
				save.ShowData();
			}
			else if (com.Equals("Exit"))
			{
				break;
			}
			else
			{
				Console.WriteLine("Invalid command");
			}


		}

	}
}