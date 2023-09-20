using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Qoueue => urutan dari pertama/atas
		Queue<int> x = new Queue<int>();
		
		x.Enqueue(3);
		x.Enqueue(4);
		x.Enqueue(7);
		x.Enqueue(5);
		x.Enqueue(8);
		
		Console.WriteLine(x.Dequeue()); //3 mengambil value
		Console.WriteLine(x.Dequeue()); //4 mengambil value
		Console.WriteLine(x.Peek()); //7 melihat value
		Console.WriteLine(x.Peek());//7 meliat value
		Console.WriteLine(x.Dequeue());//7 mengambil value
		Console.WriteLine(x.Dequeue());//5 mengambil value
		
		Console.WriteLine("");
		
		//Stack => urutan dari terakhir/ bawah
		Stack<int> y = new Stack<int>();
		y.Push(4);
		y.Push(8);
		y.Push(3);
		y.Push(2);
		
		Console.WriteLine(y.Pop());//2
		Console.WriteLine(y.Pop());//3
		Console.WriteLine(y.Peek());//8
		Console.WriteLine(y.Pop());//8
		Console.WriteLine(y.Pop());//4
		
	}
}