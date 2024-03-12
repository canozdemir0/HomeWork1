public class Program
{
    public static void Main(string[] args)
    {
        LoginApp();
    }
    public static void LoginApp()
    {
        // Kullanıcı giriş sayfası uygulaması
        // Kullanıcı adı ve şifresini doğru girerse "Tebrikler başarılı bir şekilde giriş yaptınız" yazdırınız. Yanlış girerse hata verip 3 hak tanıyıp kullanıcıya yanlış girdiği sürece döngü dönmeye devam etsin.

        int numberOfRights = 3;

        while (true)
        {
            Console.WriteLine("Kullanıcı adı: ");
            string name = Console.ReadLine();

            Console.WriteLine("Parola: ");
            string password= Console.ReadLine();

            if (name == "canozdemir" && password == "dilasen")
            {
                Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız. :) ");
                break;
            }

            else
            {
                Console.WriteLine("Kullanıcı adı veya parola yanlış girildi. Lütfen tekrar deneyin.");

                if(numberOfRights > 0)
                {
                    numberOfRights--;
                }
                if (numberOfRights == 0)
                {
                    Console.WriteLine("Kullanıcı adı veya parola 3 defa yanlış girildi ve hesabınız bloke edildi. :(");
                    break;
                }

                Console.ReadLine();
            }

         }

    }
}