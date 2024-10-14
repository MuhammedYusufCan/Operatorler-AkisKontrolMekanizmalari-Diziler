namespace _26_Bitwise_Operatörler_ile_Mantıksal_İşlemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2; // a değişkenine 2 atanır
            int b = 3; // b değişkenine 3 atanır
            int c = 6; // c değişkenine 6 atanır

            // Bitwise AND işlemi
            Console.WriteLine(" (a & b) --> " + (a & b)); // a ve b'nin bitwise AND işlemi yapılır
                                                          // a = 2 (0000 0010), b = 3 (0000 0011) --> Sonuç: 2 (0000 0010)

            // Bitwise OR işlemi
            Console.WriteLine(" (a | b) --> " + (a | b)); // a ve b'nin bitwise OR işlemi yapılır
                                                          // Sonuç: 3 (0000 0011)

            // Bitwise XOR işlemi
            Console.WriteLine(" (a ^ b) --> " + (a ^ b)); // a ve b'nin bitwise XOR işlemi yapılır
                                                          // Sonuç: 1 (0000 0001)

            // Bitwise NOT işlemi
            Console.WriteLine(" ( ~a ) --> " + (~a)); // a'nın bitwise NOT işlemi yapılır
                                                      // a = 2 (0000 0010) --> Sonuç: -3 (1111 1101) [İkilik sistemde tüm bitler ters çevrildiğinde]

            // Bitwise NOT işlemi
            Console.WriteLine(" ( ~b ) --> " + (~b)); // b'nin bitwise NOT işlemi yapılır
                                                      // b = 3 (0000 0011) --> Sonuç: -4 (1111 1100)

            // Bitwise NOT işlemi
            Console.WriteLine(" ( ~c ) --> " + (~c)); // c'nin bitwise NOT işlemi yapılır
                                                      // c = 6 (0000 0110) --> Sonuç: -7 (1111 1001)

        }
    }
}
