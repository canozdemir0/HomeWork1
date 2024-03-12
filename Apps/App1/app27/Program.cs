public class Program
{
    public static void Main(string[] args)
    {
        // WHILE döngüsü örnekler
        // App1();
        // App2();
        // DO WHILE döngüsü örnekler
        // App3();
        App4();
        
    }
    public static void App1()
        // 0 ile 10 arasındaki sayıları ekrana yazdırınız. (while döngüsü ile)
    {
        int i = 0;

        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.ReadLine();
    }
    public static void App2()

    // 100'den 0 'a kadar olan sayıların çift olanlarını büyükten küçüğe yazdırın. (while döngüsü ile)
    {
        int i = 100;

        while (i <= 0)
        {
            Console.WriteLine(i);
            i = i - 2;
        }
        Console.ReadLine();
    }
    public static void App3()
    // 0 ile 10 arasındaki sayıları ekrana yazdırınız. (do while döngüsü ile)
    {
        int i = 0;

        do
        {
            Console.WriteLine(i);
            i++;
        } while (i<=10);

    }
    public static void App4()
    // 100'den 0 'a kadar olan sayıların toplamını ekrana yazdırın. (do while döngüsü ile)

    {
        int i = 1;
        int total= 0;
        do
        {
            total += i;
            i++;
        } while (i <= 100 );

        Console.WriteLine("1'den 100'e kadar olan sayıların toplamı: "+total);
    }

}