namespace _24_Konsol_Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim; // Kullanıcının seçimlerini tutacak değişken

            do
            {
                // Kullanıcıya gösterilecek menü
                Console.WriteLine("İşlemler\n========");
                Console.WriteLine("1 - Toplama");
                Console.WriteLine("2 - Çıkarma");
                Console.WriteLine("3 - Çarpma");
                Console.WriteLine("4 - Bölme");
                Console.WriteLine("0 - Çıkış\n");
                Console.WriteLine("İşleminizi Seçin"); // Kullanıcıdan seçim alınması istenir
                secim = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girişi alınır ve tamsayıya dönüştürülür

                // Kullanıcının seçimlerine göre yapılacak işlemler
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Toplama işlemi seçildi."); // Toplama işlemi seçildi mesajı
                        break;
                    case 2:
                        Console.WriteLine("Çıkarma işlemi seçildi."); // Çıkarma işlemi seçildi mesajı
                        break;
                    case 3:
                        Console.WriteLine("Çarpma işlemi seçildi."); // Çarpma işlemi seçildi mesajı
                        break;
                    case 4:
                        Console.WriteLine("Bölme işlemi seçildi."); // Bölme işlemi seçildi mesajı
                        break;
                    case 0:
                        Console.WriteLine("Çıkış seçildi."); // Çıkış işlemi seçildi mesajı
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim"); // Geçersiz bir seçim yapıldığında mesajı
                        break;
                }
            }
            while (secim != 0); // secim 0 olmadığı sürece döngü devam eder

        }
    }
}
