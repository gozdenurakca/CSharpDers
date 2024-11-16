namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region If Else

            /*
             IF -> eğer 
            Console.Write("Lütfen şifreyi giriniz : ");
            string password;
            password = Console.ReadLine();

            Console.WriteLine();
            if (password == "123456")
            {
                Console.WriteLine("Şifreyi doğru girdiniz.");
            } else {
                Console.WriteLine("Yanlış şifre girildi.");
            }

            Console.ReadLine();
            */

            /*
             string capital, country;
            Console.Write("Başkenti giriniz : ");
            capital = Console.ReadLine();
            Console.Write("Ülkeyi giriniz : ");
            country = Console.ReadLine();

            Console.WriteLine();
            if (capital == "Ankara" & country =="Türkiye") {
                Console.WriteLine("Veriler doğrulandı.");
            }
            else
            {
                Console.WriteLine("Hatalı bilgi.");
            }
            */

            /*
            int number;
            Console.WriteLine("Sayı giriniz : ");
            number = int.Parse(Console.ReadLine());

            if (number == 5)
            {
                Console.WriteLine("Sayı doğru.");
            }
            else
            {
                Console.WriteLine("Sayı hatalı.");
            }
            */

            /*
             int exam1, exam2, exam3;
            Console.Write("1.sınav notunu girin : ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("2.sınav notunu girin : ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("3.sınav notunu girin : ");
            exam3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            double average;
            average  = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların ortalaması : " + average);
            string result = "";

            Console.WriteLine();
            if (average >= 80 & average <= 100)
            {
                result = "A";
                Console.WriteLine("Harf notunuz : " + result);
            }
            else if (average <= 79 & average >= 60)
            {
                result = "B";
                Console.WriteLine("Harf notunuz : " + result);
            }
            else if (average <= 69 & average >= 50)
            {
                result = "C";
                Console.WriteLine("Harf notunuz : " + result);
            }
            else if (average <= 59 & average >= 40)
            {
                result = "D";
                Console.WriteLine("Harf notunuz : " + result);
            }
            else if (average <= 49 & average >=0)
            {
                result = "F";
                Console.WriteLine("Harf notunuz : " + result);
            }
            else
            {
                Console.WriteLine("Hatalı giriş yapıldı, baştan deneyin.");
            }
            */

            /*
            string city;
            Console.Write("Enter your city: ");
            city = Console.ReadLine();
            if (city == "adana" || city == "bursa" || city == "ankara" || city == "trabzon")
            {
                Console.WriteLine("Şehir mevcut.");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil");
            }
            */
            
            /*
            Console.Write("Enter your username: ");
            string userName = Console.ReadLine();

            if (userName != "admin") // != -> değil anlamı verir
            {
                Console.Write("Bu kullanıcı adı kabul edilemez.");
            }
            else
            {
                Console.Write("Hoşgeldiniz.");
            }
            */
            
            








            #endregion

            #region Mod İşlemleri
            
            // mod işlemi --> iki sayının birbirine bölümünden kalanı

            /*int number;
            number = 26;
            int result = number % 5;
            Console.WriteLine(result);*/
            
            /*
            Console.Write("Lütfen 1. sayıyı giriniz : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz : ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int result = number1 % number2;
            Console.WriteLine("1. sayının 2. sayıya bölümünden kalan : " + result);
            */

            /*
            Console.Write("Lütfen bir sayı giriniz : ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " sayısı çifttir.");
            }
            else
            {
                Console.WriteLine(number + " sayısı tektir.");
            }
            */

            
            #endregion

            #region Char Değişkenler ile Karar Yapıları

            /*
            Console.Write("Lütfen g,G,f,F,t,T,b,B harflerinden birini giriniz -> ");
            char karakter = char.Parse(Console.ReadLine());

            if (karakter == 'f' || karakter =='F')
            {
                Console.WriteLine("Fenerbahçe");
            } else if (karakter == 't' || karakter =='T')
            {
                Console.WriteLine("Trabzonspor");
            } else if (karakter == 'g' || karakter =='G')
            {
                Console.WriteLine("Galatasaray");
            } else if (karakter == 'b' || karakter =='B')
            {
                Console.WriteLine("Beşiktaş");
            }
            else
            {
                Console.WriteLine("Seçenekler arasında bulunmayan bir harf girdiniz, tekrar deneyin.");
            }
            */
            
            #endregion

            #region Örnek Proje Uygulaması
            /*
            Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Çorbalar");
            Console.WriteLine("3- Pizzalar");
            Console.WriteLine("4- İçecekler");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            Console.Write("Lütfen detayını görmek istediğiniz menü seçimi: ");
            string menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("----- Ana Yemekler -----");
                Console.WriteLine();
                Console.WriteLine("1- Köri Soslu Tavuk");
                Console.WriteLine("2- Kızartma Tabağı");
                Console.WriteLine("3- Kuru fasulye & pilav");
                Console.WriteLine("4- Fırında Somon");
                Console.WriteLine("5- Patlıcan Musakka");
                Console.WriteLine();
            }
            else if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("----- Çorbalar -----");
                Console.WriteLine();
                Console.WriteLine("1- Mercimek Çorbası");
                Console.WriteLine("2- Arpa Şehriye Çorbası");
                Console.WriteLine("3- Yoğurt Çorbası");
                Console.WriteLine("4- Ezogelin Çorbası");
                Console.WriteLine("5- Ayranaşı Çorbası");
                Console.WriteLine();
            }
            else if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("----- Pizzalar -----");
                Console.WriteLine();
                Console.WriteLine("1- Margarita");
                Console.WriteLine("2- Karışık");
                Console.WriteLine("3- Akdeniz");
                Console.WriteLine("4- Tavuklu Çorbası");
                Console.WriteLine();
            } 
            else if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("----- İçecekler -----");
                Console.WriteLine();
                Console.WriteLine("1- Ayran");
                Console.WriteLine("2- Kola");
                Console.WriteLine("3- Su");
                Console.WriteLine();
            }  
            else if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("----- Tatlılar -----");
                Console.WriteLine();
                Console.WriteLine("1- Kadayıf");
                Console.WriteLine("2- Sütlaç");
                Console.WriteLine("3- Trileçe");
                Console.WriteLine("4- Baklava");
                Console.WriteLine();
            }
            */


            #endregion

            #region Switch-case
            
            
            /*
            Console.Write("Lütfen ay numarası giriniz -> ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.Write("January"); break;
                case 2:
                    Console.Write("February"); break;
                case 3:
                    Console.Write("March"); break;
                case 4:
                    Console.Write("April"); break;
                case 5:
                    Console.Write("May"); break;
                case 6:
                    Console.Write("June"); break;
                case 7:
                    Console.Write("July"); break;
                case 8:
                    Console.Write("August"); break;
                case 9:
                    Console.Write("September"); break;
                case 10:
                    Console.Write("October"); break;
                case 11:
                    Console.Write("November"); break;
                case 12:
                    Console.Write("December"); break;
                default: 
                    Console.Write("Yanlış bir sayı girildi, bu sayıya ait bir ay yok.");
                break;
            }
            */
            

            

            #endregion

            #region Switch-case Hesap Makinesi

            /*
            int number1, number2, result;
            Console.Write("Lütfen 1. sayıyı giriniz ->");
            number1=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Lütfen 2. sayıyı giriniz ->");
            number2=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Lütfen + || - || * || / sembollerinden birini giriniz.");
            char sembol = char.Parse(Console.ReadLine());
            
            switch (sembol)
            {
                case '+' :
                    result = number1 + number2;
                    Console.WriteLine("Toplam : " + result); break;
                case '-' : 
                    result = number1 - number2;
                    Console.WriteLine("Fark : " + result); break;
                case '*' : 
                    result = number1 * number2;
                    Console.WriteLine("Çarpım : " + result); break;
                case '/' : 
                    result = number1 / number2;
                    Console.WriteLine("Bölüm : " +result); break;
                default: Console.Write("Farklı bir sembol girdiniz, hatalı..");
                    break;
 
            }
            */

            #endregion
            
            
            Console.Read();
            


        }
    }
}
