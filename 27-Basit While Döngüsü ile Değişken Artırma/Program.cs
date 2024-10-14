namespace _27_Basit_While_Döngüsü_ile_Değişken_Artırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // Döngü kontrol değişkeni, başlangıçta 0 olarak ayarlandı.

            while (i < 5) // i'nin değeri 5'ten küçük olduğu sürece döngü çalışacak.
            {
                Console.WriteLine("i= " + i); // Mevcut i değeri ekrana yazdırılır.
                i++; // i'nin değeri 1 artırılır.
            }
        }
    }
}
