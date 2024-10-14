namespace _11_Bit_Kaydırma_İşlemleri_Sola_ve_Sağa_Kaydırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 0xFF;                // b'nin başlangıç değeri 0xFF (255 ondalık değeri)
            b = (byte)(b << 4);          // b'yi 4 bit sola kaydır (0xFF << 4 = 0xF0, ondalık değeri 240)
            Console.WriteLine(b);        // Çıktı: 240

            b = (byte)(b >> 3);          // b'yi 3 bit sağa kaydır (0xF0 >> 3 = 0x1E, ondalık değeri 30)
            Console.WriteLine(b);        // Çıktı: 30
        }
    }
}
