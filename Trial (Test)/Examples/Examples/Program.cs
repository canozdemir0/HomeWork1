public class Program
{
    public static void Main(string[] args)
    {
        // Example0();
        Example1 ();
    }
    public static void Example0()
    {
        // Çarpım tablosu yapınız...

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + "x" + j + "=" + (i * j));
            }
        }
        Console.ReadLine();
    }
    public static void Example1()
    {
        // Kullanıcı giriş sayfası uygulaması...
        // Kullanıcı adı ve şifresini doğru girerse => Tebrikler başarılı bir şekilde giriş yaptınız.
        // Yanlış girerse hata verelim ve 3 hak tanıyalım.

        Console.WriteLine("Hoşgeldiniz\n");

        int hakSayisi = 3;

        while (true)
        {

            Console.Write("Kullanıcı adınızı giriniz: ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifrenizi giriniz: ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "Canozdemir" && sifre == "Dila")
            {
                Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız :)\n");
                break;
            }

            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre yanlış.\n");

                if (hakSayisi > 0) 
                {
                    hakSayisi--;
                }
                if (hakSayisi == 0) 
                {
                    Console.WriteLine("Hakkınız bitmiş olup hesabınız bloke edilmiştir.\n");
                    break;
                }
            }

            Console.ReadLine();
            
        }
    }
}