using Day35_Nlog1;
using NLog;

class Program
{
	private static Logger logger = LogManager.GetCurrentClassLogger();

	static void Main()
	{
		var currentDirectory = Directory.GetCurrentDirectory();
		var nlogConfigPath = Path.Combine(currentDirectory, "nlog.config");
		LogManager.LoadConfiguration(nlogConfigPath);

		logger.Info("Starting robot arm program");

		int i = 0;
		Condision con = new Condision();
		while (i < 100)
		{
			con.Connect();
			con.MoveTo(0, 0, 0);
			con.Grab();
			con.MoveTo(10, 10, 10);
			con.Release();
			con.Disconnect();
			i++;
			//}

			logger.Info("Robot arm program finished");
		}
	}
}