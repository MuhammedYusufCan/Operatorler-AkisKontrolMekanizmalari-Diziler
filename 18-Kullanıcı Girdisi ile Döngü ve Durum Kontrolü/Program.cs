namespace _18_Kullanıcı_Girdisi_ile_Döngü_ve_Durum_Kontrolü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myInput;                // Kullanıcıdan alınan girdi için bir string değişkeni
            int myInt;                     // Kullanıcının girdiği sayıyı saklamak için bir tam sayı değişkeni

        begin:                        // Etiket: Başlangıç noktası
            Console.WriteLine("Lütfen 1 ve 3 arasında bir sayı giriniz. "); // Kullanıcıdan 1 ile 3 arasında bir sayı girmesi isteniyor
            myInput = Console.ReadLine(); // Kullanıcının girdiği değer okunuyor
            myInt = Int32.Parse(myInput);  // Girilen değer tam sayıya dönüştürülüyor ve myInt değişkenine atanıyor

            // Kullanıcının girdiği sayıya göre durumları kontrol etmek için switch yapısı kullanılıyor
            switch (myInt)
            {
                case 1:                 // Eğer myInt 1 ise
                    Console.WriteLine("Sayınız {0}", myInt); // Mesaj yazdırılıyor
                    break;             // Switch bloğundan çıkılıyor
                case 2:                 // Eğer myInt 2 ise
                    Console.WriteLine("Sayınız {0}", myInt); // Mesaj yazdırılıyor
                    break;             // Switch bloğundan çıkılıyor
                case 3:                 // Eğer myInt 3 ise
                    Console.WriteLine("Sayınız {0}", myInt); // Mesaj yazdırılıyor
                    break;             // Switch bloğundan çıkılıyor
                default:                // Yukarıdaki durumların hiçbiri sağlanmazsa
                    Console.WriteLine("Sayınız {0} 1 ve 3 arasında değil.", myInt); // Hata mesajı yazdırılıyor
                    break;             // Switch bloğundan çıkılıyor
            }

        decide:                     // Etiket: Karar verme noktası
            Console.WriteLine("Type \"continue\" to go on or \"quit\" to stop:"); // Kullanıcıdan devam etmek veya çıkmak için girdi isteniyor
            myInput = Console.ReadLine(); // Kullanıcının girdiği değer okunuyor

            // Kullanıcının girdisine göre işlem yapmak için switch yapısı kullanılıyor
            switch (myInput)
            {
                case "continue":       // Eğer myInput "continue" ise
                    goto begin;       // Başlangıç noktasına geri dönülüyor
                case "quit":          // Eğer myInput "quit" ise
                    Console.WriteLine("Bye"); // Veda mesajı yazdırılıyor
                    break;            // Switch bloğundan çıkılıyor

                default:               // Yukarıdaki durumların hiçbiri sağlanmazsa
                    Console.WriteLine("Your input {0} is incorrect.", myInput); // Hata mesajı yazdırılıyor
                    goto decide;      // Karar verme noktasına geri dönülüyor
            }

            // Kullanıcının girdiği sayıya göre bir durum daha kontrol ediliyor
            switch (myInt)
            {
                case 1:                // Eğer myInt 1 ise
                case 2:                // Eğer myInt 2 ise
                case 3:                // Eğer myInt 3 ise
                    Console.WriteLine("Your number {0}.", myInput); // Mesaj yazdırılıyor
                    break;            // Switch bloğundan çıkılıyor
                default:               // Yukarıdaki durumların hiçbiri sağlanmazsa
                    Console.WriteLine("Your number {0} is not between 1 and 3.", myInput); // Hata mesajı yazdırılıyor
                    break;            // Switch bloğundan çıkılıyor

            }
        }
}
