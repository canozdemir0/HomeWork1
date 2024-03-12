public class Program
{
  public static void Main(string[] args)
  {
    //WaterBillCalculation();
    // SwitchCase();
    // BodyMass();
    // SwitchSample3();
    // Arrays();
    // ArraySample1();
    // FindVowelCount();
    // Polindrom();
    // FindCityByPlate();
    AnswerQuestionSample();
  }

  // Birim fiyatı  15 m3 kadar 23.72 TL olan
  // 15 m3 den sonrası 34.14 TL olan su faturasının
  // ÇTV m3 başına 1.5 TL'dir
  // KDV ise %1 üzerinden hesaplanacak olup, fatura toplam tutarı ne kadardır.

  public static void WaterBillCalculation()
  {
    Console.WriteLine("Kaç m3 kullanıldı");
    double m3 = double.Parse(Console.ReadLine());

    decimal cost = 0; // tüketim bedeli

    if (m3 > 0 && m3 <= 15)
    {
      // m3 double ama sen onu çarpım işlem sonucu decimal çıksın diye decimal formatında yazdır.
      cost = (decimal)m3 * 23.72M;

      // tüketim bedeli bulundu artık üzerine vergi ekleyeceğiz.
      decimal ctv = Convert.ToDecimal(m3 * 1.5);
      Console.WriteLine($"ÇTV {ctv}");
      decimal kdv = Convert.ToDecimal((cost + ctv) * 0.01M);
      Console.WriteLine($"KDV {kdv}");
      decimal totalCost = cost + ctv + kdv;
      Console.WriteLine($"Toplam Tüketim Bedeli: {totalCost}");
    }
    else if (m3 > 15)
    {
      cost = (15 * 23.72M) + (((decimal)m3 - 15) * 34.14M);

      // tüketim bedeli bulundu artık üzerine vergi ekleyeceğiz.
      decimal ctv = Convert.ToDecimal(m3 * 1.5);
      Console.WriteLine($"ÇTV {ctv}");
      decimal kdv = Convert.ToDecimal((cost + ctv) * 0.01M);
      Console.WriteLine($"KDV {kdv}");
      decimal totalCost = Math.Round(cost + ctv + kdv, 3); // Yuvarlama
      Console.WriteLine($"Toplam Tüketim Bedeli: {totalCost}");
    }
    else
    {
      Console.WriteLine("m3 değeri 0 dan büyük olmalıdır");
    }

    // 45.5 => 46
    // 44.3 => 44
    // 44.49 => 45

  }


  /// <summary>
  /// Birden fazla koşul olduğu durumda kullanılan bir karar ifadesidir.
  /// if else if yapısına göre daha randımanlı çalışır
  /// </summary>

  public static void SwitchCase()
  {
    Console.WriteLine("Bir gün giriniz");
    string day = Console.ReadLine();
    // aşğıdaki ilk case if li hali
    //if(day == "Pazartesi" || day == "pazartesi" || day == "pzt")
    //{
    //  Console.WriteLine("Haftanın ilk iş günü");
    //}


    //if(day == "Pazartesi")
    //{

    //}
    //else if(day == "Salı")
    //{

    //}
    //else if(day == "Çarşamba")
    //{

    //}



    switch (day)
    {
      case "Pazartesi":
      case "pazartesi":
      case "pzt":
        Console.WriteLine("Haftanın ilk iş günü");
        break; // swtich değerinden çıkmak için break ifadesi kullanılır
      case "Salı":
        Console.WriteLine("Haftanın ikinici iş günü");
        break;
      case "Çarşamba":
        Console.WriteLine("Haftanın üçüncü günü");
        break;
      case "Perşembe":
        Console.WriteLine("Haftanın 4.günü");
        break;
      case "Cuma":
        Console.WriteLine("Haftanın son iş günü");
        break;
      default: // burası else gibi
        Console.WriteLine("Hafta sonu");
        break;
    }


  }


  /*
   * 
   * VKİ: 58 / (1,59)*(1,59) = 22,9 kg/m2
   * 
   * 18, 5 kg/m² ‘nin altındaki sonuçlar: İdeal kilonun altında
    18, 5 kg/m² ile 24, 9 kg/m² arasındaki sonuçlar: İdeal kiloda
    25 kg/m² ile 29, 9 kg/m² arasındaki sonuçlar: İdeal kilonun üstünde
    30 kg/m² ile 39, 9 kg/m² arasındaki sonuçlar: İdeal kilonun çok üstünde (obez)
    40 kg/m² üzerindeki sonuçlar: İdeal kilonun çok üstünde (morbid obez)
   * 
   * 
   */
  public static void BodyMass()
  {
    // Consoldan kusuralı değerler girerken . yerine , yazalım.

    Console.WriteLine("Boy giriniz (m)");
    double tall = double.Parse(Console.ReadLine());
    Console.WriteLine("Kilo griniz (kg)");
    double weight = double.Parse(Console.ReadLine());

    double vki = weight / Math.Pow(2, tall); // 2^3 // 1.72^2

    // switch case && yada || ifadeleri ile kullanılacağı zaman kullanılır; yazılm şekli =>  "case degisken_tipi degisken_ismi when kosul" syntax kullanılır 
    switch (vki)
    {
      case double a when a <= 18.5:
        Console.WriteLine("İdeal kilonun altında");
        break;
      case double b when b > 18.5 && b <= 24.9:
        Console.WriteLine("İdeal kilo");
        break;
      case double result when result > 24.9 && result <= 29.9:
        Console.WriteLine("ideal kilonun üstünde");
        break;
      case double result when result > 29.9 && result <= 39.9:
        Console.WriteLine("İdeal kilonun çok üstünde");
        break;
      default:
        Console.WriteLine("Lütfen zayıflayınız");
        break;
    }

    Console.WriteLine($"vki {vki}");


    //switch (5)
    //{
    //  case 5 % 2 == 0:

    //}


  }

  // girilen bir sayının 2 nin 3 'ün mü 5'in mi 7 nin mi katı olduğunu bulan algoritmayı switch case when yapısı ile yapalım.

  public static void SwitchSample3()
  {
    Console.WriteLine("Sayı giriniz");
    int number = int.Parse(Console.ReadLine());

    switch (number)
    {
      case int result when result % 2 == 0 && result % 3 == 0: //12
        Console.WriteLine("Hem 2 nin hem 3 ün katı");
        break;
      case int result when result % 2 == 0 && result % 5 == 0: //10
        Console.WriteLine("Hem 2 nin hem 5 ün katı");
        break;
      case int result when result % 2 == 0:
        Console.WriteLine("Sayı 2 nin katı");
        break;
      case int result when result % 3 == 0:
        Console.WriteLine("Sayı 3'ün katı");
        break;
      case int result when result % 5 == 0:
        Console.WriteLine("Sayı 5'in katı");
        break;
      case int result when result % 7 == 0:
        Console.WriteLine("Sayı 7 nin katı");
        break;

      default:
        Console.WriteLine("Sayı 5,7,3,2 nin katından biri değildir.");
        break;
    }
  }


  public static void Arrays() // Diziler
  {
    // [] dizi işareti
    // diziler ile çalışırken değişken isimlerimize s takısı ekliyoruz
    // [5] dizideki eleman sayısını temsil der
    // int tamsayı dizisini temsil eder.
    int[] numbers = new int[5];
    numbers[0] = 5; // dizinin 0. indeksine 5 değerini ata
    numbers[1] = 6;
    numbers[2] = 15;
    numbers[3] = 25;
    numbers[4] = 52; // son eleman yani numbers.lenght-1. eleman

    // numbers.Length dizinin uzunluğu kadar dön
    for (int i = 0; i < numbers.Length; i++)
    {
      Console.WriteLine($"{i}.elaman = {numbers[i]}");
    }


  }

  // Kullanıcın klavyeden girdiği metnini harf harf ayıran programı yazalım
  public static void ArraySample1()
  {
    Console.WriteLine("Bir metinsel ifade giriniz");
    string text = Console.ReadLine(); // ALİ => A L İ, string gizli bir karakterler dizisidir

    for (int i = 0; i < text.Length; i++)
    {
      Console.WriteLine(text[i]);
    }
  }

  // girilen bir metindeki sesli harf sayısını bulan programın algoritmasını yazalım
  // a,e,i,ı,o,ö,u,ü

  public static void FindVowelCount()
  {
    Console.WriteLine("Bir metin giriniz");
    string text = Console.ReadLine();
    int counter = 0;

    for (int i = 0; i < text.Length; i++)
    {
      switch (text[i])
      {
        case 'i': // c# tek tırnak char yani karakteri temsil eder, "" karakter dizisi yani string temsiil eder.
        case 'ı':
        case 'u':
        case 'ü':
        case 'o':
        case 'ö':
        case 'a':
        case 'e':
          counter++;
          Console.WriteLine($"Harf {text[i]}");
          break;
        default:
          break;
      }
    }

    Console.WriteLine($"Toplam sesli adet sayısı: {counter}");
  }

  // klavyeden girilen bir metin ile metnin tersinin birbirine eşit olup olmadığını bulan pogramın algoritmasını yazalım Örn:(KAZAK, ASA, TAT)
  // biz buna polindrom diyoruz.
  // Girilen metin polindromdur yada değildir diye ekrana bir çıktı yazdırıyoruz.

  public static void Polindrom()
  {
    Console.WriteLine("Bir metin giriniz");
    string text = Console.ReadLine();
    string reverseText = "";

    // tersten
    //for (int i = text.Length -1; i >= 0 ; i--)
    //{
    //  reverseText += text[i]; // a,s,a
    //}

    // düzden
    for (int i = 0; i < text.Length; i++)
    {
      reverseText += text[(text.Length - 1 - i)];
    }

    if (text == reverseText)
    {
      Console.WriteLine("Polindromdur");
    }
    else
    {
      Console.WriteLine("Polindrom değildir");
    }


  }

  // klavyeden girilen plakaya göre hangi şehir olduğunu ekrana yazdıran program yazalım.


  public static void FindCityByPlate()
  {
    string[] _cities = new string[5];
    _cities[0] = "istanbul";
    _cities[1] = "ankara";
    // tek satırda diziye eleman ekleme işlemi
    string[] cities = { "istanbul", "ankara", "bursa", "izmir", "antalya" };
    int[] plates = { 34, 06, 16, 35, 07 };

    Console.WriteLine("Bir plaka giriniz");
    int plate = int.Parse(Console.ReadLine());//06
    int foundIndex = -1; // dizi eleamanı dışındaysa -1 ile dizin bir elemanı olmadığını işaretledik

    for (int index = 0; index < plates.Length; index++)
    {
      if (plates[index] == plate)
      {
        foundIndex = index; // plakanın bulunduğu konum.
        break;
      }
    }

    if (foundIndex != -1)
    {
      Console.WriteLine($"Bulunan Şehir {cities[foundIndex]}");
    }
    else
    {
      Console.WriteLine("Şehir bulunamadı");
    }

  }



  // klavyeden 3 adet soruyu ve cevabını giren, bu 3 adet sorundan 1 tanesini rastgele olarak kullanıcıya soran, verilen cevap doğru ise tebrikler, değilse maalesef bilemediniz, cevap şuydu diyen algoritmayı yazınız.
  // Türkiyenin başkenti neresi ?, Türkiyedeki En büyük Göl?, Türkiyenin en Kuzeydeki şehri ?
  // Ankara, Van Gölü, Sinop

  // Türkiyenin en Kuzeydeki şehri soru? Ankara Yanlıi Sinop Doğru.

  public static void AnswerQuestionSample()
  {
    Console.WriteLine("Kaç adet soru girişi yuapılacak");
    int questionCount = int.Parse(Console.ReadLine());

    string[] questions = new string[questionCount];
    string[] answers = new string[questionCount];


    for (int i = 0; i < questionCount; i++)
    {
      Console.WriteLine($"{i+1}.soruyu giriniz");
      questions[i]= Console.ReadLine();
      Console.WriteLine($"{i+1}.sorunun cevabını giriniz");
      answers[i] = Console.ReadLine();
    }

    Random rdm = new Random();
    int index = rdm.Next(0, questionCount);

    Console.WriteLine(questions[index]);
    string answer = Console.ReadLine();

    if(answer == answers[index])
    {
      Console.WriteLine("Tebrikler bildiniz");
    }
    else
    {
      Console.WriteLine($"{questions[index]} sorunun cevabı {answers[index]} dir");
    }

  }



}
