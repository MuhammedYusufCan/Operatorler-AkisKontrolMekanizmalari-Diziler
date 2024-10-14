namespace _7_Boolean_Değerlerin_İncelenmesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b1 = 20 < 30;         // 20, 30'dan küçüktür, sonuç: true
            bool b2 = 30 < 20;         // 30, 20'den küçüktür, sonuç: false
            bool b3 = 20.53 > 20.532;  // 20.53, 20.532'den büyüktür, sonuç: false
            bool b4 = 12.3f > 11.9f;   // 12.3, 11.9'dan büyüktür, sonuç: true
            bool b5 = 15 <= 15;        // 15, 15'e eşittir veya küçüktür, sonuç: true
            bool b6 = 20 >= 30;        // 20, 30'dan büyük veya eşit değildir, sonuç: false

            // Her bir boolean değişkeninin değerini ekrana yazdırır
            Console.WriteLine(b1);  // Çıktı: true
            Console.WriteLine(b2);  // Çıktı: false
            Console.WriteLine(b3);  // Çıktı: false
            Console.WriteLine(b4);  // Çıktı: true
            Console.WriteLine(b5);  // Çıktı: true
            Console.WriteLine(b6);  // Çıktı: false
        }
    }
}
