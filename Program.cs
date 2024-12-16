namespace Vücut_Kitle_Endeksi_VKE_Hesaplayıcı_Body_Mass_Index__BMI__Calculator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vücut Kitle Endeksi Hesaplama
            VucutKitleEndeksiHesapla();
        }
        static void VucutKitleEndeksiHesapla()
        {
            Console.WriteLine("Vücut Kitle Endeksi (VKE) Hesaplayıcı\n");

            double boy = 0;
            double kilo = 0;

            // Boy bilgisi al ve kontrol et
            while (boy <= 0)
            {
                Console.Write("Boyunuzu metre cinsinden girin (örnek: 1.75): ");
                if (double.TryParse(Console.ReadLine(), out boy) && boy > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız! Lütfen boyunuzu metre cinsinden (örnek: 1.75) ve sıfırdan büyük bir değer olarak girin.\n");
                }
            }

            // Kilo bilgisi al ve kontrol et
            while (kilo <= 0)
            {
                Console.Write("Kilonuzu kilogram cinsinden girin: ");
                if (double.TryParse(Console.ReadLine(), out kilo) && kilo > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız! Lütfen kilonuzu kilogram cinsinden ve sıfırdan büyük bir değer olarak girin.\n");
                }
            }

            // VKE hesaplama formülü: kilo / (boy * boy)
            double vke = kilo / (boy * boy);

            // Sonucu yazdır
            Console.WriteLine($"\nVücut Kitle Endeksiniz: {vke:F2}");

            // Sınıflandırma
            if (vke < 18.5)
            {
                Console.WriteLine("Durum: Zayıf");
            }
            else if (vke >= 18.5 && vke < 24.9)
            {
                Console.WriteLine("Durum: Normal kilolu");
            }
            else if (vke >= 25 && vke < 29.9)
            {
                Console.WriteLine("Durum: Fazla kilolu");
            }
            else
            {
                Console.WriteLine("Durum: Obez");
            }

            // Tekrar hesaplama seçeneği
            Console.WriteLine("\nBaşka bir hesaplama yapmak ister misiniz? (Evet/Hayır)");
            string seçim = Console.ReadLine()?.ToLower();

            if (seçim == "evet")
            {
                VucutKitleEndeksiHesapla();
            }
            else
            {
                Console.WriteLine("Program sonlandırılıyor...");
            }
        }
    }
}
