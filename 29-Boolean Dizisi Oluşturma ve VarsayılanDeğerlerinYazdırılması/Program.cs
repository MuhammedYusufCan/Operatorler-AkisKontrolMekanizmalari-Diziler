namespace _29_Boolean_Dizisi_Oluşturma_ve_VarsayılanDeğerlerinYazdırılması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dizinin boyutunu giriniz=");
            int boyut = Convert.ToInt32(Console.ReadLine());
            bool[] dizi = new bool[boyut]; // Belirtilen boyutta bir bool dizisi oluşturma
            for (int i = 0; i < boyut; i++)
                Console.WriteLine(dizi[i]); // Dizinin her elemanını yazdırma (varsayılan olarak false)
            Console.ReadLine(); // Konsolu kapatmak için

        }
    }
}
