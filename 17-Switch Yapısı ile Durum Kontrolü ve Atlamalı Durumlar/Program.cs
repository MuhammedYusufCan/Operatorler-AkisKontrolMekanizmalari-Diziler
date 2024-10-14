namespace _17_Switch_Yapısı_ile_Durum_Kontrolü_ve_Atlamalı_Durumlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir sayı girmesi isteniyor
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değer tam sayıya dönüştürülerek sayi değişkenine atanıyor

            // Kullanıcının girdiği sayıya göre farklı durumları kontrol etmek için switch yapısı kullanılıyor
            switch (sayi)
            {
                case 1:                   // Eğer sayi 1 ise
                case 2:                   // Eğer sayi 2 ise
                    Console.WriteLine("Case 1 ve 2"); // 1 veya 2 için bu mesaj yazdırılıyor
                    break;                // Switch bloğundan çıkılıyor
                case 3:                   // Eğer sayi 3 ise
                    Console.WriteLine("Case 3"); // Mesaj yazdırılıyor
                    break;                // Switch bloğundan çıkılıyor
                case 4:                   // Eğer sayi 4 ise
                    Console.WriteLine("Case 4"); // Mesaj yazdırılıyor
                    goto case 5;          // Case 5'e atlıyor
                case 5:                   // Eğer sayi 5 ise
                    Console.WriteLine("Case 5"); // Mesaj yazdırılıyor
                    break;                // Switch bloğundan çıkılıyor
                default:                  // Yukarıdaki durumların hiçbiri sağlanmazsa
                    Console.WriteLine("Default"); // Hata mesajı yazdırılıyor
                    break;                // Switch bloğundan çıkılıyor
            }
    }
}
