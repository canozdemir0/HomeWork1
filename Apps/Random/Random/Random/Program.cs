public class Program
{

    public static void Main(string[] args)
    {
        Random1();

    }
    public static void Random1()
    {
        Random rastgele = new Random();
        Console.WriteLine("--- Atama Programı ---");

        string[] cities = { "İstanbul", "Ankara", "İzmir", "Erzurum", "Konya", "Isparta", "Kahramanmaraş", "Gaziantep" };
        int i = rastgele.Next(cities.Length);

        Console.Write("--- "+cities[i]+" ---");
        Console.ReadLine();

    }

}