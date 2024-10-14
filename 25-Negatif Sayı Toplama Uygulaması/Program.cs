namespace _25_Negatif_Sayı_Toplama_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, t = 0; // Kullanıcının gireceği sayı için bir değişken ve toplamı tutacak değişken

            while (true) // Sonsuz döngü
            {
                Console.WriteLine("Negatif bir sayı girin:"); // Kullanıcıdan negatif sayı girmesi istenir
                sayi = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girişi alınır ve tamsayıya dönüştürülür
                if (sayi == 0) break; // Eğer girilen sayı 0 ise döngüden çıkılır
                if (sayi > 0) // Eğer girilen sayı pozitif ise
                {
                    Console.WriteLine("Pozitif sayı girdiniz, tekrar deneyin..."); // Kullanıcıya uyarı mesajı gösterilir
                    continue; // Döngünün başına dönülür
                }
                t = t + sayi; // Negatif sayı girildiyse, toplam değişkenine eklenir
            }
            Console.WriteLine("Toplam : {0}", t); // Toplam negatif sayıların sonucu ekrana yazdırılır

        }
    }
}
