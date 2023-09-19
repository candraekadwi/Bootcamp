
using System.Collections;

class Program
{
	static void Main()
	{
		//Array
		int[] arrayInt1 ={1,2,3};
		int[] arrayInt2 = new int[3];
		arrayInt2[0]=2;
		arrayInt2[1]=0;
		arrayInt2[2]=8;
		
		Console.WriteLine(arrayInt1.Length);
		Array.Resize(ref arrayInt1, 4);
		Console.WriteLine(arrayInt1);
		
		Array.Sort(arrayInt2);
		Array.Reverse(arrayInt1);
		
		
		//ArrayList
		ArrayList list = new ArrayList()
		{
			2,"2",4,true,"haha",false
		};
		int open= (int)list[0];
		
		//HashSet
		HashSet<int> setA = new HashSet<int>{1,2,3,2};
		HashSet<int> setB = new HashSet<int>{3,2,4,3};
		
		HashSet<int>union = new HashSet<int>(setA);
		union.UnionWith(setB);
		
		
		HashSet<int> intersection = new HashSet<int>(setA);
		//intersection.IntersectionWith(setB); //4,5

		HashSet<int> difference = new HashSet<int>(setA);
		difference.ExceptWith(setB);
	
	
		//Linked List
		LinkedList<int> linkedList = new LinkedList<int>(); 
		linkedList.AddLast(1); 
		linkedList.AddLast(2); 
		linkedList.AddLast(3); 
		linkedList.AddFirst(0); 
		LinkedListNode<int> node = linkedList.Find(1); 
		linkedList.AddAfter(node, 1); 
		linkedList.Remove(2); 
		foreach (int value in linkedList) 
		{ Console.WriteLine(value); }
	}
	
}
