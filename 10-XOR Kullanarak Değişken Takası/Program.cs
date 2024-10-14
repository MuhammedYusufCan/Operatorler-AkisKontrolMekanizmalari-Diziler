namespace _10_XOR_Kullanarak_Değişken_Takası
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 195;  // X'in başlangıç değeri 195
            int Y = 26;   // Y'nin başlangıç değeri 26

            // XOR (özel veya) işlemi kullanarak X ve Y'nin değerlerini takas etmek
            X = X ^ Y;    // X = 195 ^ 26 (X'in yeni değeri: 211)
            Y = Y ^ X;    // Y = 26 ^ 211 (Y'nin yeni değeri: 195)
            X = X ^ Y;    // X = 211 ^ 195 (X'in yeni değeri: 26)

            // X ve Y'nin son değerlerini ekrana yazdırır
            Console.WriteLine("X:{0}\nY:{1}", X, Y);  // Çıktı: X:26 Y:195

        }
    }
}
