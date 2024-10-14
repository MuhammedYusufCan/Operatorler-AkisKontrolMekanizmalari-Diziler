namespace _28_Çift_Değişken_Kullanımı_ile_For_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, j = 0; i < 20; i++, j++)
            {
                i *= j; // i, j ile çarpılır.
                Console.WriteLine("i=" + i + " j=" + j); // i ve j'nin mevcut değerleri yazdırılır.
            }

        }
    }
}
