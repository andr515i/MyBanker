namespace MyBanker
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				DebitCard dc = new DebitCard("Tue", 12);
				Maestro m = new Maestro("Tue", 19);
				MasterCard mc = new MasterCard("Tue", 22);
				Electron e = new Electron("Tue", 5);
				Visa v = new Visa("Tue", 95);
				//Console.WriteLine(dc.ToString()); 
				//Console.WriteLine(m.ToString()); 
				//Console.WriteLine(mc.ToString()); 
				//Console.WriteLine(e.ToString()); 
				Console.WriteLine(v.ToString()); 

			}
			Console.Read();
		}
	}
}