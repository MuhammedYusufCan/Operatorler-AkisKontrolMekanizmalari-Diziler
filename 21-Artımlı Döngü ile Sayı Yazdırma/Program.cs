namespace _21_Artımlı_Döngü_ile_Sayı_Yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, a, n; // i değişkeni döngü sayacı olarak başlatılıyor, a ve n değişkenleri kullanıcıdan alınacak değerler için tanımlanıyor
            Console.Write("Bir sayı girin: "); // Kullanıcıdan bir sayı girmesi isteniyor
            n = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değer tam sayıya çevrilip n değişkenine atanıyor

            Console.Write("Artım Miktarı:"); // Kullanıcıdan artım miktarını girmesi isteniyor
            a = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değer tam sayıya çevrilip a değişkenine atanıyor

            // i değişkeni n'den küçük olduğu sürece döngü devam edecek
            for (; i < n;)
            {
                Console.Write("{0} ", i); // i'nin mevcut değeri ekrana yazdırılıyor
                i += a; // i'nin değeri, artım miktarı olan a kadar artırılıyor
            }
        }
    }
}
