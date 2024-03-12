public class Program
{
    public static void Main(string[] args)
    {

        HomeWork3();

    }
    // 5- klavyeden girilen bir metnin minimum 8 karakter olmalıdır, içerisinde en az 1 adet küçük harf, 1 adet büyük harf ve 3 adet rakam olmalıdır. Bunu hesaplayan algoritmayı yazınız. Cevap: Girilen metin istenilen değerler ile eşleşiyor yada eşleşmiyor. Ali347Ka eşleşti handesunda eşleşmedi 01234567 eşleşmedi.
    public static void HomeWork3()
    {
        Console.BackgroundColor= ConsoleColor.DarkRed;
        Console.Title = "HomeWork";
        Console.Write("Parola giriniz: ");
        string password = Console.ReadLine();

        if (PasswordControl(password))

        {
            Console.WriteLine("Parola uygun ");

        }

        else

        {
            Console.WriteLine("Parola uygun değil ");
        }

        static bool PasswordControl(string password)

        {

            // Şifre'nin uzunluğu en az 8 karakter olmalıdır.

            if (password.Length < 8)
            {
                return false;
            }

            // En az bir adet küçük harf içermelidir.

            if (!password.Any(char.IsLower))

            {
                return false;
            }

            // En az bir büyük harf içermelidir.

            if (!password.Any(char.IsUpper))
            {

                return false;
            }

            // En az üç adet sayı içermelidir.

            if (password.Count(char.IsDigit) < 3)
            {
                return false;
            }

            // Tüm şartlar sağlanıyor ise true döndür.
            return true;
        }

        Console.ReadLine();

    }

}
