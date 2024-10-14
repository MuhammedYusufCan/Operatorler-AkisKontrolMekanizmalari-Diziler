namespace _6_Karşılaştırma_Operatörleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 15;  // a'nın değeri 10, b'nin değeri 15

            // a ve b'nin eşit olup olmadığını kontrol eder
            if (a == b)
                Console.WriteLine("a,b'ye eşittir");

            // a'nın b'den küçük olup olmadığını kontrol eder
            if (a < b)
                Console.WriteLine("a,b'den küçüktür");  // Bu koşul sağlanır, çıktı: "a,b'den küçüktür"

            // a'nın b'den büyük olup olmadığını kontrol eder
            if (a > b)
                Console.WriteLine("a,b'den büyüktür");

            // a ve b'nin eşit olup olmadığını kontrol eder
            if (a != b)
                Console.WriteLine("a,b'ye eşit değil");  // Bu koşul sağlanır, çıktı: "a,b'ye eşit değil"

            // a'nın b'ye eşit veya büyük olup olmadığını kontrol eder
            if (a >= b)
                Console.WriteLine("a,b'ye eşittir veya büyüktür");

            // a'nın b'ye eşit veya küçük olup olmadığını kontrol eder
            if (a <= b)
                Console.WriteLine("a,b'ye eşittir veya küçüktür");  // Bu koşul sağlanır, çıktı: "a,b'ye eşittir veya küçüktür"
        }
    }
}
