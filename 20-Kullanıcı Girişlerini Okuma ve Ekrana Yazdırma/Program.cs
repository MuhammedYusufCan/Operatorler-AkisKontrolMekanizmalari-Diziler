namespace _20_Kullanıcı_Girişlerini_Okuma_ve_Ekrana_Yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s; // Kullanıcıdan alınacak metni tutmak için bir değişken tanımlanıyor

            // Kullanıcıdan bir giriş alınıyor ve döngü, "Çıkış" kelimesi girilene kadar devam ediyor
            for (s = Console.ReadLine(); s != "Çıkış"; s = Console.ReadLine())
                Console.WriteLine(s); // Kullanıcının girdiği her metin, "Çıkış" kelimesi girilene kadar ekrana yazdırılıyor

        }
    }
}
