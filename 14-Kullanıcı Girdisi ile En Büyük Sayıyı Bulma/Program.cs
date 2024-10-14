namespace _14_Kullanıcı_Girdisi_ile_En_Büyük_Sayıyı_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;                       // Kullanıcıdan alınan veriyi saklamak için bir string değişkeni
            int a, b, c;                   // Üç adet tam sayı değişkeni tanımlanıyor

            // Kullanıcıdan 1. sayıyı girmesi isteniyor
            Console.Write("1.sayıyı giriniz : ");
            s = Console.ReadLine();        // Kullanıcının girdiği değer okunuyor
            a = Int32.Parse(s);           // Girilen değer tam sayıya dönüştürülüyor ve a'ya atanıyor

            // Kullanıcıdan 2. sayıyı girmesi isteniyor
            Console.Write("2.sayıyı giriniz : ");
            s = Console.ReadLine();        // Kullanıcının girdiği değer okunuyor
            b = Int32.Parse(s);           // Girilen değer tam sayıya dönüştürülüyor ve b'ye atanıyor

            // Kullanıcıdan 3. sayıyı girmesi isteniyor
            Console.Write("3.sayıyı giriniz : ");
            s = Console.ReadLine();        // Kullanıcının girdiği değer okunuyor
            c = Int32.Parse(s);           // Girilen değer tam sayıya dönüştürülüyor ve c'ye atanıyor

            // En büyük sayıyı belirlemek için koşullar kontrol ediliyor
            if (a >= b && a >= c)          // Eğer a, b ve c'den büyük veya eşitse
                Console.WriteLine("Enbüyük :" + a); // a yazdırılıyor
            else if (b >= c)               // Eğer b, c'den büyük veya eşitse
                Console.WriteLine("Enbüyük :" + b); // b yazdırılıyor
            else                            // Aksi halde
                Console.WriteLine("Enbüyük :" + c); // c yazdırılıyor

        }
    }
}
