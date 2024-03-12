public class Program
{
    public static void Main(string[] args)
    {
        // App1();
        // App2();

    }
        public static void App1() 
    {
    Console.Write("Adınızı Giriniz: ");
    string name= Console.ReadLine();

    Console.Write("Soy adınızı giriniz: ");
    string surName= Console.ReadLine();

    Console.WriteLine("Adınız: "+name);
    Console.WriteLine("Soyadınız: " + surName);
    Console.ReadLine();

    }
    public static void App2()
          {
            Random rastgele = new Random();
        Console.WriteLine("--- Atama Programı ---");
        string[] cities = {"Ankara", "İstanbul", "Kahramanmaraş", "Trabzon", "İzmir", "Erzurum", "Isparta", "Gaziantep"};
        int i=rastgele.Next(0, cities.Length);

        // Console.WriteLine(i);
        Console.WriteLine(cities[i]);

        Console.ReadLine();
          }
    public static void App3()
    {

    }

}