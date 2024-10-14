namespace _19_1_den_N_ye_Kadar_Olan_Sayıların_Toplamını_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:"); // Kullanıcıdan bir sayı girmesini istiyor
            int n = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değeri tam sayıya çevirip n değişkenine atıyor
            int toplam = 0; // Toplamı tutacak değişkeni 0 ile başlatıyor

            // 0'dan n-1'e kadar olan sayılar için döngü başlatıyor
            for (int i = 0; i <= n; i++)
                toplam = toplam + i; // Her döngüde i değerini toplam değişkenine ekliyor

            // Toplamın sonucunu ekrana yazdırıyor
            Console.WriteLine("1\'den {0}\'e kadar olan sayıların toplamı {1}\'dir.", n, toplam);

        }
    }
}
