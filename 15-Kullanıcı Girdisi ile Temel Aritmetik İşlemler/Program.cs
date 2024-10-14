namespace _15_Kullanıcı_Girdisi_ile_Temel_Aritmetik_İşlemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secim;                   // Kullanıcının seçimini saklamak için bir string değişkeni
            int s1, s2;                     // İki adet tam sayı değişkeni tanımlanıyor

            // Kullanıcıdan 1. sayıyı girmesi isteniyor
            Console.WriteLine("1.Sayıyı giriniz.");
            s1 = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değer tam sayıya dönüştürülüyor ve s1'e atanıyor

            // Kullanıcıdan 2. sayıyı girmesi isteniyor
            Console.WriteLine("2.Sayıyı giriniz.");
            s2 = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değer tam sayıya dönüştürülüyor ve s2'ye atanıyor

            // Kullanıcıdan işlem seçmesi isteniyor
            Console.WriteLine("\nİşleminizi Seçin:\n============");
            Console.WriteLine("Toplama (t)");
            Console.WriteLine("Çıkarma (ç)");
            Console.WriteLine("Çarpma (x)");
            Console.WriteLine("Bölme (b)");
            Console.WriteLine("Mod Alma (m)");
            secim = Console.ReadLine();         // Kullanıcının seçim girişi okunuyor

            // Seçime göre işlemler yapılıyor
            if (secim == "t")                    // Toplama işlemi
                Console.WriteLine("Toplam = {0}", s1 + s2); // Toplama sonucu yazdırılıyor
            else if (secim == "ç")               // Çıkarma işlemi
                Console.WriteLine("Fark = {0} ", s1 - s2);   // Çıkarma sonucu yazdırılıyor
            else if (secim == "x")               // Çarpma işlemi
                Console.WriteLine("Çarpım = {0}", s1 * s2); // Çarpma sonucu yazdırılıyor
            else if (secim == "b")               // Bölme işlemi
            {
                if (s2 == 0)                     // Eğer ikinci sayı sıfır ise
                    Console.WriteLine("Bolen 0 olamaz"); // Hata mesajı yazdırılıyor
                else
                    Console.WriteLine("Bölüm = {0}", (float)s1 / (float)s2); // Bölme sonucu yazdırılıyor
            }
            else if (secim == "m")               // Mod alma işlemi
            {
                if (s2 == 0)                     // Eğer ikinci sayı sıfır ise
                    Console.WriteLine("Bolen 0 olamaz"); // Hata mesajı yazdırılıyor
                else
                    Console.WriteLine("Mod = {0}", s1 % s2); // Mod alma sonucu yazdırılıyor
            }
            else
                Console.WriteLine("Yanlış işlem seçtiniz."); // Geçersiz işlem seçimi için hata mesajı
            ;
        }
    }
}
