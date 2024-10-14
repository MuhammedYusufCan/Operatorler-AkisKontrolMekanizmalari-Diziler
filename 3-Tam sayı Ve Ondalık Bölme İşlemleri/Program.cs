namespace _3_Tam_sayı_Ve_Ondalık_Bölme_İşlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5 / 4;  // Tam sayı bölmesi, sonuç: 1 (küsurat atılır).
            float f1 = 5 / 4;  // Tam sayı bölmesi, sonuç: 1.0 (sonuç önce tam sayı olarak hesaplanır, sonra float'a atanır).
            float f2 = 5f / 4f;  // Ondalık (float) bölme, sonuç: 1.25.

            Console.WriteLine(i);   // Çıktı: 1
            Console.WriteLine(f1);  // Çıktı: 1
            Console.WriteLine(f2);  // Çıktı: 1.25
        }
    }
}
