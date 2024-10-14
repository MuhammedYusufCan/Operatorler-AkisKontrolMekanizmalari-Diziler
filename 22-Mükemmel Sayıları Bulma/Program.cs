namespace _22_Mükemmel_Sayıları_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, t, toplam, n1, n2; // k: dış döngü sayacı, t: iç döngü sayacı, toplam: bölenlerin toplamı, n1: aralık başlangıcı, n2: aralık sonu

            Console.Write("Aralık Başlangıcı :"); // Kullanıcıdan aralık başlangıcı girmesi isteniyor
            n1 = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değer tam sayıya dönüştürülerek n1'e atanıyor

            Console.Write("Aralık Sonu     :"); // Kullanıcıdan aralık sonunu girmesi isteniyor
            n2 = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değer tam sayıya dönüştürülerek n2'ye atanıyor

            // Eğer başlangıç değeri son değerden küçükse
            if (n1 <= n2)
            {
                // n1 ile n2 arasındaki her bir sayıyı kontrol etmek için döngü
                for (k = n1; k <= n2; k++)
                {
                    toplam = 0; // Her k için toplamı sıfırlıyoruz
                                // 1'den k'ya kadar olan sayıları kontrol etmek için iç döngü
                    for (t = 1; t <= k; t++)
                    {
                        if (k % t == 0) // k'nın t'ye bölümünden kalan 0 ise, yani t k'nın böleni ise
                            toplam = toplam + t; // t'yi toplam değişkenine ekle
                    }
                    // Eğer toplam, k + 1'e eşitse (k sadece 1 ve kendisi olan bir sayıysa)
                    if (toplam == k + 1)
                        Console.WriteLine(k); // k değerini ekrana yazdır
                }
            }
            else
                Console.WriteLine("Geçerli bir aralık giriniz..."); // n1, n2'den büyükse hata mesajı ver

        }
    }
}
