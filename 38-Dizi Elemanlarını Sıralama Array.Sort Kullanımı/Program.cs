namespace _38_Dizi_Elemanlarını_Sıralama_Array.Sort_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = { "Zeynep", "Fatma", "Ali", "Yılmaz", "Gökhan", "Osman", "Feride" }; // Dizi tanımlanıyor
            Console.WriteLine("Dizinin Elemanları\n========");
            foreach (string s in dizi) // Dizi elemanlarını yazdırma
                Console.WriteLine(s);

            Array.Sort(dizi); // Diziyi sıralama
            Console.WriteLine();

            Console.WriteLine("Sıralanmış Dizi\n============");
            foreach (string s in dizi) // Sıralanmış dizi elemanlarını yazdırma
                Console.WriteLine(s);
        }
    }
}
