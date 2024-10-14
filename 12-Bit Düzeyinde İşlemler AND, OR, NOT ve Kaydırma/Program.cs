namespace _12_Bit_Düzeyinde_İşlemler_AND__OR__NOT_ve_Kaydırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;  // a'nın değeri 10
            int b = 2;   // b'nin değeri 2

            // Bit ve işlemi (AND); a ve b'nin her bir bitini karşılaştırır, yalnızca her iki bit de 1 ise 1 döner.
            Console.WriteLine("bit ve işlemi=" + (int)(a & b));  // a = 10 (1010), b = 2 (0010) -> 0010 = 2

            // Bit veya işlemi (OR); a ve b'nin en az bir bitinin 1 olduğu durumlarda 1 döner.
            Console.WriteLine("bit veya işlemi=" + (int)(a | b));  // 1010 | 0010 -> 1010 = 10

            // Bit tümleyen işlemi (NOT); a'nın her bir bitini tersine çevirir.
            Console.WriteLine("bit tümleyen işlemi=" + (int)(~a));  // ~10 = -11 (Çünkü 10'un binary gösterimi 1010, tümleyen 0101 yani -11)


            // Bit sola kaydırma; 1'i b kadar bit sola kaydırır.
            Console.WriteLine("bit sola kaydırma=" + (int)(1 << b));  // 1 << 2 = 4 (100)

            // Bit sağa kaydırma; 1'i b kadar bit sağa kaydırır.
            Console.WriteLine("bit sağa kaydırma=" + (int)(1 >> b));  // 1 >> 2 = 0 (0)

            // Bit XOR işlemi; a ve b'nin bitlerini karşılaştırır, farklı olan bitlerde 1 döner.
            Console.WriteLine("bit xor işlemi=" + (int)(1 ^ b));  // 1 ^ 2 = 3 (0011)

            // Aşağıdaki satır yorum halindedir ve aşırı büyük bir değeri byte'a çevirmeye çalışmaktadır.
            // Console.WriteLine("bit tümleyen işlemi"+(byte)(~a)); // -> 245, ancak ~a = -11 olduğu için byte'a dönüştürülünce 245 olur.

        }
    }
}
