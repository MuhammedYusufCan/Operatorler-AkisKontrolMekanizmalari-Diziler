namespace _4_Arttırma_ve_Azaltma_Operatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 20;
            int d = 50;
            float f = 3.4f;

            a++;    // a = 5'ten sonra 1 artar, yeni değer: 6
            ++b;    // b = 10'dan önce 1 artar, yeni değer: 11
            c--;    // c = 20'den sonra 1 azalır, yeni değer: 19
            --d;    // d = 50'den önce 1 azalır, yeni değer: 49
            f++;    // f = 3.4'ten sonra 1 artar, yeni değer: 4.4

            // Değerler sırasıyla ekrana yazdırılır
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n", a, b, c, d, f);
            // a + c işlemi yapılır (6 + 19 = 25)
            Console.WriteLine("a + c = {0}", a + c);  // Çıktı: 25
        }
    }
}
