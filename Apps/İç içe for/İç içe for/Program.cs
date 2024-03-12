public class Program
{
    public static void Main(string[] args)
    {
        IcIceFor();
    }

    public static void IcIceFor()
   /* 1
    * 12
    * 123
    * 1234
    * 12345
    * 123456
    * 1234567
    * 12345678
    * 123456789
    */
    {

        for (int i = 1; i < 10; i++)
        {

            for (int j = 1; j < i; j++) 
            {
                Console.Write(j);
            }
            Console.WriteLine(" ");
        }

        Console.ReadLine();
    }

}