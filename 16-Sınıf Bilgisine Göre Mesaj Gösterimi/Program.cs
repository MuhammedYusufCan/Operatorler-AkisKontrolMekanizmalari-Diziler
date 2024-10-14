namespace _16_Sınıf_Bilgisine_Göre_Mesaj_Gösterimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;                       // Kullanıcıdan alınan veriyi saklamak için bir string değişkeni
            int a;                          // Kullanıcının sınıf bilgisini tutacak bir tam sayı değişkeni

            // Kullanıcıdan sınıf numarasını girmesi isteniyor
            Console.Write("Kaçıncı Sınıftasınız : ");
            s = Console.ReadLine();        // Kullanıcının girdiği değer okunuyor
            a = Int32.Parse(s);           // Girilen değer tam sayıya dönüştürülüyor ve a'ya atanıyor

            // Kullanıcının sınıfına göre mesaj belirlemek için switch yapısı kullanılıyor
            switch (a)
            {
                case (1):                  // Eğer a 1 ise
                    Console.WriteLine("Daha Yenisiniz"); // Mesaj yazdırılıyor
                    break;                 // Switch bloğundan çıkılıyor
                case (2):                  // Eğer a 2 ise
                    Console.WriteLine("Mirasçısınız"); // Mesaj yazdırılıyor
                    break;                 // Switch bloğundan çıkılıyor
                case (3):                  // Eğer a 3 ise
                    Console.WriteLine("Ev Sahibisiniz"); // Mesaj yazdırılıyor
                    break;                 // Switch bloğundan çıkılıyor
                case (4):                  // Eğer a 4 ise
                    Console.WriteLine("Misafirsiniz"); // Mesaj yazdırılıyor
                    break;                 // Switch bloğundan çıkılıyor
                default:                   // Yukarıdaki durumların hiçbiri sağlanmazsa
                    Console.WriteLine("Siz okulu uzatmışsınız"); // Hata mesajı yazdırılıyor
                    break;                 // Switch bloğundan çıkılıyor
            }
    }
}
