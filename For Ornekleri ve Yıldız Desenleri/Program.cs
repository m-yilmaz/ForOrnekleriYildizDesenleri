using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace For_Ornekleri_ve_Yildiz_Desenleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.OutputEncoding = Encoding.UTF8;
        start:
            Console.Clear();
            Console.WriteLine("| " + new string('*', 37) + " Döngü Örnekleri Ve Yıldız Deseni " + new string('*', 37) + " |\r\n");
            Console.WriteLine(new string(' ', 5) + "[1] 1'den n'ye kadar olan tüm tam sayıları yazdıran program.");
            Console.WriteLine(new string(' ', 5) + "[2] n'den 1'e kadar olan tüm tam sayıları yazdıran program.");
            Console.WriteLine(new string(' ', 5) + "[3] a'dan z'ye kadar olan harfleri (ingilizce harfler) yazdıran program.");
            Console.WriteLine(new string(' ', 5) + "[4] 1'den n'ye kadar olan tüm çift sayıları yazdıran program.");
            Console.WriteLine(new string(' ', 5) + "[5] n'den 1'e kadar olan tüm tek sayıları yazdıran program.");
            Console.WriteLine(new string(' ', 5) + "[6] 1'den n'ye kadar tüm 3'ün katı olan sayıların toplamını ekrana yazdıran program..");
            Console.WriteLine(new string(' ', 5) + "[7] n'nin katları olan sayıları 0'dan başlayarak yazdıran program.");
            Console.WriteLine(new string(' ', 5) + "[8] 1'den n'ye kadar olan sayıların toplamını yazdıran program");
            Console.WriteLine(new string(' ', 5) + "[9] Girilen n satır sayısı ile şekil çizen program.");
            Console.WriteLine(new string(' ', 5) + "[10] Çıkış\r\n");

            Console.WriteLine("| " + new string('*', 40) + " Created By Mustafa Yilmaz " + new string('*', 40) + " |");
            Console.Write("\r\nÇalıştırmak istediğiniz program numarasını yazınız: ");
            try
            {
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1'den n'ye kadar olan tüm tam sayıları yazan program çalışıyor..\r\n");
                        BirdenNKadarsayilar();
                        goto start;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("n'den 1'e kadar olan tüm tam sayıları yazan program çalışıyor..\r\n");
                        NdenBireEkadarSayilar();
                        goto start;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("a'dan z'ye kadar olan harfleri (ingilizce harfler) yazdıran program çalışıyor..\r\n");
                        AdanZyeIngilizceHarfler();
                        goto start;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("1'den n'ye kadar olan tüm çift sayıları yazdıran program çalışıyor..\r\n");
                        BirdenNKadarCiftSayilar();
                        goto start;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("n'den 1'e kadar olan tüm tek sayıları yazdıran program çalışıyor..\r\n");
                        NdenBireKadarTekSayilar();
                        goto start;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("1'den n'ye kadar tüm 3'ün katı olan sayıların toplamını ekrana yazdıran program çalışıyor..\r\n");
                        BirdenNKadarUcKatlari();
                        goto start;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("7. n'nin katları olan sayıları 0'dan başlayarak yazdıran program çalışıyor..\r\n");
                        NinKatiOlanSayilar();
                        goto start;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("1'den n'ye kadar olan sayıların toplamını yazdıran program çalışıyor..\r\n");
                        BirdenNeKadarToplam();
                        goto start;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Şekiller\r\n");
                        Sekiller();
                        goto start;
                    case 10:
                        Console.Clear();
                        Console.Write("Çıkış yapılıyor");
                        for (int i = 0; i < 2; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(1000);
                        }
                        break;
                    default:
                        Console.Clear();
                        goto start;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Geçersiz giriş!");
                goto start;
            }

            // 1. 1'den n'ye kadar olan tüm tam sayıları yazdırınız.
            void BirdenNKadarsayilar()
            {
            input:
                try
                {
                    Console.Write("N: ");
                    int giris = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= giris; i++)
                    {
                        Console.Write(i + " ");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Sadece sayı giriniz.");
                    goto input;
                }
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }
            // 2. n'den 1'e kadar olan tüm tam sayıları yazdırınız.
            void NdenBireEkadarSayilar()
            {
            input:
                try
                {
                    Console.Write("N: ");
                    int giris = Convert.ToInt32(Console.ReadLine());

                    for (int i = giris; i > 0; i--)
                    {
                        Console.Write(i + " ");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Sadece sayı girmelisiniz.");
                    goto input;
                }

                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }
            // 3. a'dan z'ye kadar olan harfleri (ingilizce harfler) yazdırınız.
            void AdanZyeIngilizceHarfler()
            {
            input:
                for (int i = 97; i < 123; i++)
                {
                    char harf = Convert.ToChar(i);
                    Console.Write(harf + " ");
                }
                Console.WriteLine();
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }
            // 4. 1'den n'ye kadar olan tüm çift sayıları yazdırınız.
            void BirdenNKadarCiftSayilar()
            {
            input:
                try
                {
                    Console.Write("N: ");
                    int giris = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= giris; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }

                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Sadece sayı giriniz.");
                    goto input;
                }
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }
            // 5. n'den 1'e kadar olan tüm tek sayıları yazdırınız.
            void NdenBireKadarTekSayilar()
            {
            input:
                try
                {
                    Console.Write("N: ");
                    int giris = Convert.ToInt32(Console.ReadLine());

                    for (int i = giris; i >= 0; i--)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write(i + " ");
                        }

                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Sadece sayı giriniz.");
                    goto input;
                }

                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }
            // 6. 1'den n'ye kadar tüm 3'ün katı olan sayıların toplamını ekrana yazdırınız.
            void BirdenNKadarUcKatlari()
            {
            input:
                try
                {
                    Console.Write("N: ");
                    int giris = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= giris; i++)
                    {
                        if (i % 3 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Sadece sayı giriniz.");
                    goto input;
                }
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }
            // 7. n'nin katları olan sayıları 0'dan başlayarak yazdırınız (Örnek; n=3 ise 0, 3, 6, 9, ... 99 gibi).
            void NinKatiOlanSayilar()
            {
            input:
                try
                {
                    Console.Write("N: ");
                    int giris = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i <= 100; i++)
                    {
                        if (i % giris == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Sadece sayı giriniz.");
                    goto input;
                }
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }
            // 8. 1'den n'ye kadar olan sayıların toplamını yazdırınız.
            void BirdenNeKadarToplam()
            {
            input:
                int toplam = 0;
                try
                {
                    Console.Write("N: ");
                    int giris = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= giris; i++)
                        toplam += i;
                    Console.Write($"1'den {giris} 'e kadar sayilarin toplami =  {toplam} ");
                }
                catch (Exception)
                {

                    Console.WriteLine("Sadece sayı giriniz.");
                    goto input;
                }
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }
            // 9. Şekillerin satır sayısını, kullanıcı tarafından girilen 1'den büyük n sayısı belirlemektedir.
            void Sekiller()
            {
            input:
                try
                {
                    Console.WriteLine("Şekiller için satır sayısı giriniz.");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        Console.WriteLine("1 den büyük sayı girmelisiniz.");
                        goto input;
                    }

                    // Şekil - 1
                    Console.WriteLine("\r\nŞekil - 1");
                    Console.WriteLine();
                    for (int j = 0; j < n; j++)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }

                    // Şekil - 2

                    Console.WriteLine("\r\nŞekil - 2");
                    Console.WriteLine();
                    for (int j = 0; j < n; j++)
                    {
                        for (int i = 0; i <= j; i++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }

                    // Şekil - 3

                    Console.WriteLine("\r\nŞekil - 3");
                    Console.WriteLine();
                    for (int j = 0; j < n; j++)
                    {
                        for (int i = 0; i <= j; i++)
                        {
                            Console.Write('*');
                            Console.Write(' ');
                        }
                        Console.WriteLine();
                    }

                    // Şekil - 4
                    Console.WriteLine("\r\nŞekil - 4");
                    Console.WriteLine();
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = n - i; j > 0; j--)
                        {
                            Console.Write(' ');
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                    // Şekil - 5 
                    Console.WriteLine("\r\nŞekil - 5");
                    Console.WriteLine();
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = n - i; j > 0; j--)
                        {
                            Console.Write(' ');
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                        for (int m = 1; m < i; m++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                    // Şekil - 6 
                    Console.WriteLine("\r\nŞekil - 6");
                    Console.WriteLine();

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < 1; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }


                    // Şekil - 7
                    Console.WriteLine("\r\nŞekil - 7");
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < 1; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }


                    // Şekil - 8
                    Console.WriteLine("\r\nŞekil - 8");
                    Console.WriteLine();
                    for (int i = 0; i < n / 2; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        for (int j = (n - i * 2) - 2; j > 0; j--)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        Console.WriteLine();
                    }
                    if (n % 2 != 0)
                    {
                        for (int i = 0; i < (n - 1) / 2; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        for (int i = (n - 1) / 2; i < n; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    for (int i = n / 2 - 1; i >= 0; i--)
                    {
                        for (int j = i; j > 0; j--)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        for (int j = 0; j < (n - (i * 2) - 2); j++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        Console.WriteLine();
                    }



                    // Şekil - 9
                    Console.WriteLine("\r\nŞekil - 9");
                    Console.WriteLine();
                    for (int i = n - 1; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("*");
                        }

                    }
                    Console.WriteLine();
                    for (int i = 0; i < n - 2; i++)
                    {
                        Console.Write("*");
                        for (int j = 0; j < n - 2; j++)
                        {
                            Console.Write(' ');
                        }
                        Console.Write("*");
                        Console.WriteLine();
                    }
                    for (int i = n - 1; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("*");
                        }

                    }
                    Console.WriteLine();


                    // Şekil - 10
                    Console.WriteLine("\r\nŞekil - 10");
                    Console.WriteLine();
                    if (n % 2 == 0)
                    {
                        for (int i = 1; i <= n / 2; i++)
                        {
                            for (int j = n - i; j > n / 2; j--)
                            {
                                Console.Write(' ');
                            }
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }
                            for (int m = 1; m < i; m++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        for (int i = n / 2; i > 0; i--)
                        {
                            for (int j = n - i; j > n / 2; j--)
                            {
                                Console.Write(' ');
                            }
                            for (int k = i; k >= 1; k--)
                            {
                                Console.Write("*");
                            }
                            for (int m = 1; m < i; m++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();

                        }
                    }
                    else
                    {
                        for (int i = 1; i <= (n - 1) / 2; i++)
                        {
                            for (int j = n - i; j > (n - 1) / 2; j--)
                            {
                                Console.Write(' ');
                            }
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }
                            for (int m = 1; m < i; m++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        for (int i = (n - 1) / 2; i > 0; i--)
                        {
                            for (int j = n - i; j > (n - 1) / 2; j--)
                            {
                                Console.Write(' ');
                            }
                            for (int k = i; k >= 1; k--)
                            {
                                Console.Write("*");
                            }
                            for (int m = 1; m < i; m++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();

                        }
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Sadece sayı girmelisiniz.");
                    goto input;
                }

                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }

            }
        }
    }
}
