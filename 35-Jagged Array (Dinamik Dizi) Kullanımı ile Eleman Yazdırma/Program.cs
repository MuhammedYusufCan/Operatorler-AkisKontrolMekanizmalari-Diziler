namespace _35_Jagged_Array__Dinamik_Dizi__Kullanımı_ile_Eleman_Yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] dizi = new int[3][]; // 3 elemanlı bir jagged array (dinamik dizi) oluşturuluyor
            dizi[0] = new int[] { 1, 2 }; // İlk alt dizi
            dizi[1] = new int[] { 3, 4, 5, 6, 7 }; // İkinci alt dizi
            dizi[2] = new int[] { 8, 9, 0 }; // Üçüncü alt dizi

            // Dizi elemanlarını yazdırma
            foreach (int[] boyut in dizi) // Her bir alt dizi için döngü
            {
                foreach (int eleman in boyut) // Alt dizinin elemanları için döngü
                    Console.WriteLine("{0,3}", eleman); // Elemanları yazdır
                Console.WriteLine(); // Her alt dizi sonrasında bir satır boşluk bırak
            }
        }
    }
}
