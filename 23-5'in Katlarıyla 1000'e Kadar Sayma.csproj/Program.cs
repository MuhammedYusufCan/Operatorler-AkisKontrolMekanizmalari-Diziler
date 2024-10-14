namespace _23_5_in_Katlarıyla_1000_e_Kadar_Sayma.csproj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // i değişkenini 0 ile başlatıyoruz

            // i 1000'den küçük olduğu sürece döngü devam eder
            while (i < 1000)
            {
                i += 5; // i'ye 5 ekliyoruz
                Console.Write("{0,5}", i); // i'yi 5 karakter genişliğinde ekrana yazdırıyoruz
                if (i % 50 == 0) // Eğer i 50'nin katıysa
                    Console.WriteLine(); // Bir alt satıra geçiyoruz
            }
        }
    }
}
