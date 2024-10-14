namespace _36_3_Boyutlu_Dizi_Oluşturma_ve_Rastgele_Değer_Atama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 boyutlu bir int dizisi oluşturuluyor. Boyutlar: 5, 4, 3
            Array dizi = Array.CreateInstance(typeof(int), 5, 4, 3);
            Random r = new Random(); // Rastgele sayı üreteci

            // Dizinin her bir elemanına rastgele değer atama
            for (int i = 0; i < dizi.GetLength(0); i++) // 5 eleman için döngü
                for (int j = 0; j < dizi.GetLength(1); j++) // 4 eleman için döngü
                    for (int k = 0; k < dizi.GetLength(2); k++) // 3 eleman için döngü
                    {
                        // Rastgele bir değer atama (10 ile 100 arasında)
                        dizi.SetValue(r.Next(10, 100), i, j, k);
                        // Atanan değeri yazdırma
                        Console.WriteLine("dizi[{0},{1},{2}]={3,3}", i, j, k, dizi.GetValue(i, j, k));
                    }
        }
    }
}
