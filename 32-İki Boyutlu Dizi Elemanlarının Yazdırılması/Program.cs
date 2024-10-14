namespace _32_İki_Boyutlu_Dizi_Elemanlarının_Yazdırılması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // 3x2 boyutunda bir iki boyutlu dizi tanımlanıyor

            // Dizi elemanlarını yazdırmak için döngüler
            for (int i = 0; i < 3; i++) // Satırlar için döngü
            {
                for (int j = 0; j < 2; j++) // Sütunlar için döngü
                {
                    Console.WriteLine(dizi[i, j]); // İlgili dizi elemanını yazdır
                }
            }
        }
    }
}
