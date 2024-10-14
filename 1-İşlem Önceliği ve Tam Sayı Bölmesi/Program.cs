namespace _1_İşlem_Önceliği_ve_Tam_Sayı_Bölmesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İlk işlem: 5 * 4 önce yapılır, sonuç 20 olur. Ardından 20 / 6 işlemi yapılır, 
            // tam sayı bölmesi olduğundan sonuç 3 olur.
            int i = 5 * 4 / 6;
            Console.WriteLine(i);  // Çıktı: 3

            // İkinci işlem: Parantez içindeki 4 / 6 işlemi önce yapılır ve tam sayı bölmesi
            // olduğundan sonuç 0 olur. Sonra 5 * 0 işlemi yapılır, sonuç 0 olur.
            i = 5 * (4 / 6);
            Console.WriteLine(i);  // Çıktı: 0
        }
    }
}
