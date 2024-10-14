namespace _13_Type_Veri_Tipi_ve_Dinamik_Tür_Belirleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t;                          // Type veri tipi için bir değişken tanımlanıyor.
            int i = 123;                    // i değişkenine 123 değeri atanıyor.
            float f = 23.45f;               // f değişkenine 23.45 değeri atanıyor.

            t = typeof(int);                // t değişkenine int türü atanıyor.
            Console.WriteLine(t.ToString() + "");  // t'nin değeri ekrana yazdırılıyor; çıktı: "System.Int32"
            Console.WriteLine(i.GetType());        // i'nin türü ekrana yazdırılıyor; çıktı: "System.Int32"

            t = typeof(float);              // t değişkenine float türü atanıyor.
            Console.WriteLine(t.ToString() + "");  // t'nin değeri ekrana yazdırılıyor; çıktı: "System.Single"
            Console.WriteLine(f.GetType());        // f'nin türü ekrana yazdırılıyor; çıktı: "System.Single"
        }
    }
}
