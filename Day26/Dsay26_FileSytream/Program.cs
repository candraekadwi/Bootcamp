
using System.Dynamic;
using System.IO;//filestream
using System.Text;//filestream

class Program
{
	static void Main()
	{
		string x ="";
		while(true){
		Console.Write("input Text: ");
		x=Console.ReadLine();
		using(FileStream fs= new(@"./abcd.txt",FileMode.Append,FileAccess.Write))
		{
			byte[] bytes=Encoding.UTF8.GetBytes(x);
			fs.Write(bytes,0,bytes.Length);
			Console.WriteLine($"succes");
		}
		using(FileStream fs2= new(@"./abcd.txt",FileMode.Open,FileAccess.Read))
		{
			byte[] bytes2=new byte[fs2.Length];
			fs2.Read(bytes2,0,bytes2.Length);
			string y= Encoding.UTF8.GetString(bytes2);
			Console.WriteLine($"dat:{y}");
		}
		using(FileStream fs2= new(@"./abcd.txt",FileMode.Open,FileAccess.Read,FileShare.Read))
		{
			while(true)
			{
				
			}
		}
		
	}
	}
}