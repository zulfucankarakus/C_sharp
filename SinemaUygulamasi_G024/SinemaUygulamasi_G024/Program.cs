using System;

namespace SinemaUygulamasi_G024
{
    class Program
    {
        static Sinema Snm;
        static void Main(string[] args)
        {
            Uygulama();
            //Test();
        }

        //static void Test()
        //{
            //int a=SayıAl("1. sayıyı al: ");
            //int b = SayıAl("2. sayıyı al: ");
            //Console.WriteLine("sayıların toplamı:{0}", (a + b));

        //}
        static int SayıAl(string mesaj)
        {
            int a;

            while (true)
            {
                
                Console.Write(mesaj);
                string giris = Console.ReadLine();
                if (int.TryParse(giris,out a)==true)
                {
                    return a;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız");
                }

            }
        }

        static void Uygulama()
        {
            Kurulum();
            Menu();
            while (true)
            {
                Console.WriteLine();
                string secim = SecimAl();

                switch (secim)
                {
                    case "1":
                        BiletSat();
                        break;
                    case "2":
                        BiletIade();
                        break;
                    case "3":
                        DurumBilgisi();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı");
                        break;
                }
            }
        }

        static void Kurulum()
        {
            Console.WriteLine("-------Zülfücan Karakuş Sinema Salonu-------");
            Console.Write("Film adı: ");
            string filmadı = Console.ReadLine();
            //Console.Write("Kapasite: ");
            //int kapasite = Convert.ToInt32(Console.ReadLine());
            int kapasite = SayıAl("Kapasite: ");
            //Console.Write("Tam Bilet Fiyatı: ");
            //int tambiletfiyatı = Convert.ToInt32(Console.ReadLine());
            int tambiletfiyatı = SayıAl("Tam Bilet Fiyatı: ");
            //Console.Write("Yarım Bilet Fiyatı :");
            //int yarımbiletfiyatı = Convert.ToInt32(Console.ReadLine());
            int yarımbiletfiyatı = SayıAl("Yarım Bilet Fiyatı: ");
            Snm = new Sinema(filmadı, kapasite, tambiletfiyatı, yarımbiletfiyatı);

        }
        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Bilet Sat(1)    ");
            Console.WriteLine("2 - Bilet İade(2)   ");
            Console.WriteLine("3 - Durum Bilgisi(3)");
            Console.WriteLine("4 - Çıkış(4)        ");
            Console.WriteLine();
        }

        static string SecimAl()
        {
            Console.Write("Seçiminiz: ");
            return Console.ReadLine();
        }

        static void BiletSat()
        {
            //yeterli sayıda koltuk yoksa bilet satışı yapılmasın
            Console.WriteLine();
            Console.WriteLine("Bilet sat: ");
            //Console.Write("Tam bilet adedi: ");
            //int tam = Convert.ToInt32(Console.ReadLine());
            int tam = SayıAl("Tam Bilet Adedi: ");
            //Console.Write("Yarım bilet adedi: ");
            //int yarım = Convert.ToInt32(Console.ReadLine());
            int yarım = SayıAl("Yarım Bilet Adedi: ");

            Snm.BiletSat(tam, yarım);

        }
        static void BiletIade()
        {
            //satılandan fazla bilet iade edilememsi gerek
            Console.WriteLine();
            Console.WriteLine("Bilet iade: ");
            Console.Write("Tam bilet adedi: ");
            int tam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yarım bilet adedi: ");
            int yarım = Convert.ToInt32(Console.ReadLine());

            Snm.Biletİade(tam, yarım);
        }

        static void DurumBilgisi()
        {
            Console.WriteLine();
            Console.WriteLine("Film: " + Snm.FilmAdi);
            Console.WriteLine("Kapasite: " + Snm.Kapasite);
            Console.WriteLine("Tam Bilet Fİyatı: " + Snm.TamBiletFiyati);
            Console.WriteLine("Yarım bilet fiyatı: " + Snm.YarimBiletFiyati);
            Console.WriteLine("Toplam tam bilet adedi: " + Snm.ToplamTamBiletAdedi);
            Console.WriteLine("Toplam yarım bilet adedi: " + Snm.ToplamYarimBiletAdedi);
            Console.WriteLine("Ciro: " + Snm.Ciro);
            Console.WriteLine("Boş koltuk adedi: " + Snm.BosKoltukSayısı());
        }


    }

}
