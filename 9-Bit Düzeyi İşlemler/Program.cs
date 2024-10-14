namespace _9_Bit_Düzeyi_İşlemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 254;            // b1'in değeri 254 (byte aralığı 0-255)
            byte b2 = (byte)~b1;     // b1'in bitlerinin tersini al (NOT işlemi), sonuç: 1 (254 = 11111110, NOT = 00000001)
            Console.WriteLine(b2);   // b2'nin değeri ekrana yazdırılır; Çıktı: 1
        }
    }
}
