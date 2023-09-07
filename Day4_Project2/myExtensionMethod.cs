namespace myExtensionMethod;

static class myExtensionMethod
{

	public static void printf(this string a) {
		Console.WriteLine(a);
	}
	public static void println(this string a) {
		Console.WriteLine(a);
		Console.WriteLine("");
	}
	public static void printfint(this int a) {
		Console.WriteLine(a);
	}

}
