namespace _37_Dizi_Elemanlarını_Kopyalama_CopyTo_ve_Array.Copy_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7 }; // 1, 2, 3, 4, 5, 6, 7 içeren bir dizi tanımlanıyor
            int[] dizi2 = new int[10]; // 10 elemanlı bir dizi oluşturuluyor
            int[] dizi3 = new int[10]; // 10 elemanlı başka bir dizi oluşturuluyor

            // dizi1'in elemanlarını dizi2'ye kopyalama
            dizi1.CopyTo(dizi2, 2); // dizi1'in elemanları, dizi2'nin 2. indeksinden itibaren kopyalanıyor

            // dizi2'nin elemanlarını yazdırma
            foreach (int i in dizi2)
                Console.Write(i);
            Console.WriteLine();

            // dizi1'den dizi3'e kopyalama
            Array.Copy(dizi1, 2, dizi3, 5, 3); // dizi1'den 2. indeksten başlayarak 3 elemanı dizi3'ün 5. indeksine kopyala

            // dizi3'ün elemanlarını yazdırma
            foreach (int i in dizi3)
                Console.Write(i);

        }
    }
}
