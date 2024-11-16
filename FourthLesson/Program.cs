namespace Dersler
{
    internal class FourthLesson
    {
        public static void Main(string[] args)
        {
            #region For Döngüsü
            
            // For( x;y;z)
            // x: başlangıç değeri
            // y: bitiş
            // z: artış-azalış

            /*
            int i;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            for (int i = 3; i <= 50; i += 3)
            {
                Console.WriteLine(i);
            }
            */
            /*
            int i,baslangic, bitis, artis;
            Console.Write("Lütfen başlangıç değerini giriniz : ");
            baslangic = int.Parse(Console.ReadLine());
            Console.Write("Lütfen bitiş değerini giriniz : ");
            bitis = int.Parse(Console.ReadLine());
            Console.Write("Lütfen artış değerini giriniz : ");
            artis = int.Parse(Console.ReadLine());

            for (i = baslangic; i <= bitis; i += artis)
            {
                Console.WriteLine(i);
            }
            */
            /*
            Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz : ");
            int finishValue = int.Parse(Console.ReadLine());
            for (int i = 0; i <= finishValue; i++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet !");
            }
            */
            







            #endregion

            #region For Döngüsü ile Karar Yapıları

            /*
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            int toplam = 0;
            for (int i = 1; i <=10; i++)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("Toplam : " + toplam);
            */

            /*
            int totalValue = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    totalValue = totalValue + i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("1 ile 20 arasındaki çift sayıların toplamı : " + totalValue);
            */

            /*
            int sayi = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                    sayi++;
                }
            }
            Console.WriteLine("1 ile 50 arasında 7 ye tam bölünen " + sayi+ " vardır.");
            */

            /*
            int bacterium = 1;

            for (int i = 1; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ". Saat Sonunda : " + bacterium);
            }
            */


            #endregion

            #region While Döngüsü

            // Şart sağlandığı sürece anlamı taşımaktadır.
            // artırma işlemi, işlemlerin old yerde yapılır.
            // artırma işlemi yapmayı unutursak sonsuz döngüye girer..
            
            // While(şart)
            // {
            // İşlemler
            // }

            /*
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine("Merhaba Dünya !");
                i++;
            }
            */

            /*
            int i = 1;
            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }
            */

            /*
            int i = 1;
            int toplam = 0;
            while (i <= 10)
            {
                toplam = toplam + i;
                i++;
            }
            Console.WriteLine("Toplam : " +toplam);
            */
            
            
            
            
            
            
            
            

            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            
            /*
            Console.Write("Lütfen 3 basamaklı bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            int birler, onlar, yuzler,toplam;
            birler = sayi % 10;
            onlar = (sayi % 100) / 10;
            yuzler = sayi / 100;
            
            Console.WriteLine(sayi + " sayısının yüzler basamağı : " + yuzler);
            Console.WriteLine(sayi + " sayısının onlar basamağı : " + onlar);
            Console.WriteLine(sayi + " sayısının birler basamağı : " + birler);
            
            toplam = birler + onlar + yuzler;
            Console.WriteLine("Birler bas. + Onlar bas. + Yüzler bas. = " + toplam);
            */

            #endregion

            Console.Read();
        }
    }
}