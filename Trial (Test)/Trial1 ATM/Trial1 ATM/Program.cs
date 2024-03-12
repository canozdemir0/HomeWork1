public class Program
{
    public static void Main(string[] args) 
    {
        Sample0();
        Sample1();
    }

    public static void Sample0() 
    {
        // kullanıcıya ne işlem yapmak istediğini soralım
        // 1 - Bakiye görüntüleme
        // 2 - Para çekme
        // 3 - Para yatırma
        // 4 - Çıkış

        int balance = 280523;
        Console.WriteLine("Atm'ye Hoşgeldiniz :)\n\nYapmak istediğiniz işlem için aşağıdaki adımları takip edin. \n\n1- Bakiye görüntüle \n2- Para çekme \n3- Para Yatırma \n4- Çıkış\n");
        string election=Console.ReadLine();         // election: seçim

        if (election == "1")
        {
            Console.WriteLine("\nBakiyeniz: " + balance);
                Console.ReadLine();
        }
        else if (election == "2")
        {
            Console.Write("\nÇekeceğiniz tutarı giriniz: ");
            int minusMoney = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nKalan tutar: " + (balance - minusMoney));
            Console.ReadLine();
        }
        else if (election == "3")
        {
            Console.Write("\nYatırılacak tutarı giriniz: ");
            int plusMoney = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMevcut tutar: " + (balance + plusMoney));
            Console.ReadLine();
        }
        else if (election == "4")
        {
            Console.WriteLine("\nHesabınızdan güvenle çıkış yapıldı. ");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("\nLütfen size verilen sayılarla işlem yapınız.");
            Console.ReadLine();
        }

        Console.ReadLine();
    }
    public static void Sample1()
    {

    }

}
