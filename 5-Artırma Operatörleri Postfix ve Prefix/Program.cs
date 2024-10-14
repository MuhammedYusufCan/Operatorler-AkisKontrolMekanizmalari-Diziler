namespace _5_Artırma_Operatörleri_Postfix_ve_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;     // a'nın başlangıç değeri 10
            int b, c;      // b ve c için tanım yapılıyor

            b = a++;       // b = a (10) olur; sonra a 1 artar (a = 11)
            c = ++a;      // a 1 artar (a = 12) ve c = a (12) olur

            Console.WriteLine("a = {0}", a);  // Çıktı: a = 12
            Console.WriteLine("b = {0}", b);  // Çıktı: b = 10
            Console.WriteLine("c = {0}", c);  // Çıktı: c = 12
        }
    }
}
