namespace TaksiMetreUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //açılış ücreti ve kilometre ücreti sabit değerler olduğu için const değişkeni kullanılarak sabit tutuldu.
            const double AcilisUcreti = 150;
            const double KmUcreti = 25;

            Console.Write("Gidilen mesafe (km): ");
            if (!double.TryParse(Console.ReadLine(), out double Mesafe) || Mesafe < 0)
            {
                Console.WriteLine("Hatalı giriş!");
                return;
            }

            Console.Write("Gece tarifesi var mı? (E/H): ");
            string GeceTarifesiGirdisi = Console.ReadLine().ToLower(); // Kullanıcı büyük harf veya küçük harf kullanması halinde aynı sonuç dönecektir.
            bool GeceTarifesi = GeceTarifesiGirdisi == "e";

            double ToplamUcret = AcilisUcreti + (Mesafe * KmUcreti);

            if (GeceTarifesi)
            {
                ToplamUcret *= 1.20; // %20 artır.
            }

            Console.WriteLine($"Toplam ücret: {ToplamUcret:F2} TL");
        }
    }
}
