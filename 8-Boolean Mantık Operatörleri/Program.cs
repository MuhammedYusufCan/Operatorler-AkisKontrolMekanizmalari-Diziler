namespace _8_Boolean_Mantık_Operatörleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;   // a'nın değeri true
            bool b = false;  // b'nin değeri false

            // XOR (özel veya) operatörü; yalnızca biri true ise true döner. (a ^ b = true)
            if (a ^ b)
                Console.WriteLine("a^b doğrudur");  // Bu koşul sağlanır, çıktı: "a^b doğrudur"

            // AND (ve) operatörü; her ikisi de true ise true döner. (a && b = false)
            if (a && b)
                Console.WriteLine("a ve b doğrudur");  // Bu koşul sağlanmaz, hiçbir çıktı olmaz.

            // OR (veya) operatörü; en az bir tanesi true ise true döner. (a || b = true)
            if (a || b)
                Console.WriteLine("a veya b doğrudur");  // Bu koşul sağlanır, çıktı: "a veya b doğrudur"
        }
    }
}
