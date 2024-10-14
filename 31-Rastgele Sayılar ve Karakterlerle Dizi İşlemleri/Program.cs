namespace _31_Rastgele_Sayılar_ve_Karakterlerle_Dizi_İşlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); // Rastgele sayı üretici nesnesi oluşturuluyor
            int[] dizi = new int[20]; // 20 elemanlı bir int dizisi oluşturuluyor
            char[] chr = new char[20]; // 20 elemanlı bir char dizisi oluşturuluyor

            // Diziye rastgele değerler atama
            for (int i = 0; i < 20; i++)
            {
                dizi[i] = r.Next(1, 51); // 1 ile 50 arasında rastgele bir sayı atıyoruz
                chr[i] = (char)r.Next(20, 126); // 20 ile 125 arasındaki değerleri char'a dönüştürerek atıyoruz
            }

            // Dizi değerlerini ve karşılık gelen karakterleri yazdırma
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0,2}.değer {1,2} -> ", i, dizi[i]); // Dizi elemanını yazdırıyoruz
                for (int j = 0; j < dizi[i]; j++) // dizi[i] kadar karakter yazdırıyoruz
                    Console.WriteLine(chr[i]); // İlgili karakteri yazdırıyoruz
                Console.WriteLine(); // Boş bir satır yazdırıyoruz
            }

        }
    }
}
