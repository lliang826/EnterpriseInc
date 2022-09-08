using MyLibrary;

public class Booboo {
	public static void Main(String[] args) {
		Console.Write("Please enter your name: ");
		String? name = Console.ReadLine();

		Console.WriteLine(Helper.Reverse(name!));
	}GCNotificationStatus
}