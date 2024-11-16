
namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            #region Double Değişkenler
            
            // double number;
            // number = 4.85;
            // Console.WriteLine(number);
            
            // Console.WriteLine("***** Fiyat Listesi *****");
            // Console.WriteLine();
            //
            // double applePrice,orangePrice,strawberryPrice,potatoPrice,tomatoPrice;
            //
            // applePrice = 14.85;
            // orangePrice = 20.95;
            // strawberryPrice = 45 ;
            // potatoPrice = 9.74;
            // tomatoPrice = 6.88;
            //
            // Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL");
            // Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL");
            // Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            // Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL");
            // Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL");
            // Console.WriteLine();
            // Console.WriteLine();
            //
            // double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            // appleGram = 1.245;
            // orangeGram = 2.650;
            // strawberryGram = 0.750 ;
            // potatoGram = 4.859 ;
            // tomatoGram = 3.745;
            //
            // double totalApplePrice = applePrice*appleGram;
            // double totalOrangePrice = orangePrice*orangeGram;
            // double totalStrawberryPrice = strawberryPrice*strawberryGram;
            // double totalPotatoPrice = potatoPrice*potatoGram;
            // double totalTomatoPrice = tomatoPrice*tomatoGram;
            //
            // Console.WriteLine("Alınan ürün : Elma - Birim Fiyat : " +applePrice+ " - Gramaj : " + appleGram + " kg Ödenecek Tutar: " +totalApplePrice + " TL");
            // Console.WriteLine("Alınan ürün : Portakal - Birim Fiyat : " +orangePrice+ " - Gramaj : " + orangeGram + " kg Ödenecek Tutar: " + totalOrangePrice+ " TL");
            // Console.WriteLine("Alınan ürün : Çilek - Birim Fiyat : " +strawberryPrice+ " - Gramaj : " + strawberryGram + " kg Ödenecek Tutar: " +totalStrawberryPrice + " TL");
            // Console.WriteLine("Alınan ürün : Patates - Birim Fiyat : " +potatoPrice+ " - Gramaj : " + potatoGram + " kg Ödenecek Tutar: " +totalPotatoPrice + " TL");
            // Console.WriteLine("Alınan ürün : Domates - Birim Fiyat : " +tomatoPrice+ " - Gramaj : " + tomatoGram + " kg Ödenecek Tutar: " +totalTomatoPrice + " TL");
            //
            //
            // double shoppingTotalPrice = totalApplePrice+totalOrangePrice+totalStrawberryPrice+totalPotatoPrice+totalTomatoPrice;
            // Console.WriteLine("Toplam alışveriş bütçesi : " + shoppingTotalPrice + " TL");
            //
            //



            #endregion

            #region Char Değişkenler
            
            // ABCDEFGH
            // Sezar şifreleme : +3 karakter atar
            // TOPLANTI SAAT 20:00'DE
            // normal stringler "" içerisinde tanımlanırken, char'lar tek tırnak içinde tanımlanır.

            //
            // char symbol;
            // symbol = 'A';
            // Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //
            // Console.WriteLine("**** C# Hava Yolları Yolcu Bilgisi ****");
            // Console.WriteLine();
            //
            // string passengerName, passengerSurname, passengerAge,passengerDistrict, passengerCity, passengerIdentityNumber;
            //
            // Console.Write("Yolcu adı : ");
            // passengerName = Console.ReadLine();
            // Console.Write("Yolcu Soyadı : ");
            // passengerSurname = Console.ReadLine();
            // Console.Write("Yolcu Yaşı : ");
            // passengerAge = Console.ReadLine();
            // Console.Write("Yolcu İlçe : ");
            // passengerDistrict = Console.ReadLine();
            // Console.Write("Yolcu İl : ");
            // passengerCity = Console.ReadLine();
            // Console.Write("Yolcu TC Kimlik Numarası: ");
            // passengerIdentityNumber = Console.ReadLine();
            //
            // Console.WriteLine();
            // Console.WriteLine("-----------------");
            //
            // Console.WriteLine("Yolcu TC kimlik Numarası : " + passengerIdentityNumber + " Yolcu Adı & Soyadı : " + passengerName + " " + passengerSurname + " " + passengerAge + " " + passengerDistrict + " /  " + passengerCity);
            
            #endregion

            #region Tam Sayı Girişleri ve Dönüşümler

            // int shoesPrice, computerPrice, chairPrice, tvPrice;
            // shoesPrice = 1000;
            // computerPrice = 20000;
            // chairPrice = 5000;
            // tvPrice = 12000;
            //
            // int shoesCount, computerCount, chairCount, tvCount;
            //
            // Console.Write("Lütfen aldığınız ayakkabı miktarını giriniz : ");
            // shoesCount = int.Parse(Console.ReadLine());
            // Console.Write("Lütfen aldığınız bilgisayar miktarını giriniz : ");
            // computerCount = int.Parse(Console.ReadLine());
            // Console.Write("Lütfen aldığınız sandalye miktarını giriniz : ");
            // chairCount = int.Parse(Console.ReadLine());
            // Console.Write("Lütfen aldığınız tv miktarını giriniz : ");
            // tvCount = int.Parse(Console.ReadLine());
            //
            // int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice +
            //                  tvCount * tvPrice;
            //
            // Console.WriteLine();
            // Console.WriteLine("Ödemeniz gereken tutar: " + totalPrice + " TL");
            //
            

            #endregion
            
            #region Klavyeden Ondalıklı Sayı İşlemleri

            // double exam1, exam2, exam3, result;
            // Console.Write("1.Sınav notunu giriniz : ");
            // exam1 = double.Parse(Console.ReadLine());
            // Console.Write("2.Sınav notunu giriniz : ");
            // exam2 = double.Parse(Console.ReadLine());
            // Console.Write("3.Sınav notunu giriniz : ");
            // exam3 = double.Parse(Console.ReadLine());
            //
            // Console.WriteLine();
            // result = (exam1 + exam2 + exam3) / 3;
            // Console.WriteLine("Ortalamanız : " + result);
            //
            //

            #endregion

            #region Klavyeden Karakter Girişleri

            // char gender;
            // Console.Write("Lütfen cinsiyetinizi seçiniz : ");
            // gender = char.Parse(Console.ReadLine());
            //
            // Console.WriteLine();
            // Console.WriteLine("Seçtiğiniz cinsiyet : " + gender);
            //
            #endregion
            
            Console.Read();

        }
    }
    
}

