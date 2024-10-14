namespace _34_Farklı_Uzunlukta_Alt_Dizilerle_Çok_Boyutlu_Dizi_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] dizi = new int[3][]; // 3 elemanlı bir çok boyutlu dizi oluşturuyoruz
            dizi[0] = new int[] { 1, 2 }; // İlk satır
            dizi[1] = new int[] { 3, 4, 5, 6, 7 }; // İkinci satır
            dizi[2] = new int[] { 8, 9, 0 }; // Üçüncü satır

            // Dizi elemanlarını yazdırma
            for (int i = 0; i < dizi.Length; i++) // Dizi boyutunu al
            {
                for (int j = 0; j < dizi[i].Length; j++) // Alt dizinin boyutunu al
                {
                    Console.WriteLine("Dizi[{0}][{1}] = {2}", i, j, dizi[i][j]);
                }
            }
        }
    }
}
