namespace _33_Simetrik_İki_Boyutlu_Dizi_Doldurma_ve_Yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[4, 4]; // 4x4 boyutunda iki boyutlu dizi tanımlanıyor
            int k = 1; // Dizi elemanlarını doldurmak için bir sayaç

            // Dizi elemanlarını doldurmak için döngüler
            for (int i = 0; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    dizi[i, j] = k; // Elemanı atama
                    dizi[j, i] = k; // Simetrik elemanı da atama
                    k++; // Sayaç artır
                }
            }

            // Dizi elemanlarını yazdırmak için foreach döngüsü
            k = 1; // Sayaç sıfırlanıyor
            foreach (int x in dizi)
            {
                if (k % 4 == 0) // Her 4 elemanda bir satır atla
                {
                    Console.Write(x + " "); // Elemanı yazdır
                    Console.WriteLine(); // Yeni satıra geç
                }
                else
                {
                    Console.Write(x + " "); // Elemanı yazdır
                }
                k++; // Sayaç artır
            }
        }
    }
}
