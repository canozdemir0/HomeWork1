public class Program
{

    public static void Main(string[] args)
    {
        // Dongu0();
        Dongu1();
    }

    public static void Dongu0()
    {
        // 1'den 10'a kadar olan sayıları yazdıran programı yazınınz.
        int i = 1;
        while (i <= 10) 
        {
            Console.WriteLine(i);
            i++;
        }
        // 100'den 0'a ikişer ikişer inen programı yazınız.

        // int i = 100;
        // while (i >= 0) 
        // {
        //    Console.WriteLine(i);
        //    i = i - 2;
        // }

        Console.ReadLine();
    }
    public static void Dongu1()
    {
        // 1'den 10'a kadar olan sayıları yazdıran programı yazınınz.

        /*
         * int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        }while(i <= 10);
        */

        // 100'den 0'a ikişer ikişer inen programı yazınız.

        int j = 100;
        do
        {
        Console.WriteLine(j);
            j = j - 2;
        }while(j >= 0);

        Console.ReadLine(); 
    }

}