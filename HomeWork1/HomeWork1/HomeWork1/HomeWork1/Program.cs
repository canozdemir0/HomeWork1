using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class program
{
    public static void Sample1()
    {
        int number1, number2, number3;

        Console.WriteLine("Birinci sayıyı giriniz.");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı giriniz.");
        number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Üçüncü sayıyı giriniz.");
        number3 = int.Parse(Console.ReadLine());

        if (number1 > number2 && number1 < number3) 
        {
            Console.WriteLine("Ortanca sayı: "+ number1);
        }
        else if (number2 > number1 && number2 < number3)
        {
            Console.WriteLine("Ortanca sayı: " + number2);
        }
        else if (number3 > number1 && number3 < number2)
        {
            Console.WriteLine("Ortanca sayı: " + number3);
        }
        else
        {
            Console.WriteLine("Tüm sayılar eşittir.");
        }

    }
    public static void Sample2()
    {
        int number1, number2, number3;

        Console.WriteLine("1. Sayıyı Giriniz:");
        number1= int.Parse(Console.ReadLine());

        Console.WriteLine("2. Sayıyı Giriniz:");
        number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("3. Sayıyı Giriniz:");
        number3 = int.Parse(Console.ReadLine());

        float result = ((number1 + number2 + number3) / 3);

        if (result >= 50 && result <= 100)
        {
            Console.WriteLine("Başarılı :)");
        }
        else if (result > 100) 
        {
            Console.WriteLine("Geçersiz sayı...");
        }
        else
        {
            Console.WriteLine("Başarısız :(");
        }



    }
    public static void Sample3()
    {
        int loop = 0;
        Console.Write("Sayıyı Girin : ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                loop++;
            }
        }
        if (loop == 0)
        {
            Console.WriteLine("Girilen Sayı Asaldır. ");
        }
        else
        {
            Console.WriteLine("Girilen Sayı Asal Değildir. ");
        }
    }
    public static void Sample4()
    {

         Console.WriteLine("1. Sayıyı Giriniz: ");
         int number1=int.Parse(Console.ReadLine());

         Console.WriteLine("2. Sayıyı Giriniz: ");
         int number2 = int.Parse(Console.ReadLine());

         Console.WriteLine("3. Sayıyı Giriniz: ");
         int number3 = int.Parse(Console.ReadLine());

         Console.WriteLine("4. Sayıyı Giriniz: ");
         int number4 = int.Parse(Console.ReadLine());

         Console.WriteLine("5. Sayıyı Giriniz: ");
         int number5 = int.Parse(Console.ReadLine());

        int oddSum = 0;
        int evenSum = 0;

        if (number1 % 2 == 0) 
        {
            //oddSum = oddSum + number1 aşağıdakinin aynısı.
            evenSum += number1;
        }
        
        else
        {
            oddSum+= number1;
        }

        if (number2 % 2 == 0)
        {
            evenSum += number2;
        }

        else
        {
            oddSum += number2;
        }

        if (number3 % 2 == 0)
        {
            evenSum += number3;
        }

        else
        {
            oddSum += number3;
        }

        if (number4 % 2 == 0)
        {
            evenSum += number4;
        }

        else
        {
            oddSum += number4;
        }

        if (number5 % 2 == 0)
        {
            evenSum += number5;
        }

        else
        {
            oddSum += number5;
        }

        Console.WriteLine("Çift Sayıların Toplamı :" + evenSum);
        Console.WriteLine("Tek Sayıların Toplamı:" + oddSum);

    }
    public static void Main(string[] args)
    {
            // Sample1();
            // Sample2();
            // Sample3();
            // Sample4();

    }

}
