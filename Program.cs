
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Kimliyinizin seriya nomresi");
        string seriya=Console.ReadLine();
        Console.WriteLine("Adinizi daxil edin");
        string ad = Console.ReadLine();
        Console.WriteLine("Soyadinizi daxil edin ");
        string soyad = Console.ReadLine();
        Console.WriteLine("Tevelludunuzu yazin");
        int tev = Convert.ToInt32(Console.ReadLine());
        int yas = 2023 - tev;
        if (yas > 0 || yas < 6)
        {
            Console.WriteLine("Ceki daxil edin");
            double ceki = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Size bilet odenishsizdir.Siz maksimum 10 kq ceki apara bilersiniz");
            if (ceki > 15)
            {
                Console.WriteLine("Ceki size uygun deyil");
            }
            else
            {
                Console.WriteLine("Cekini apara bilersiniz ");
            }
            if (yas > 7 || yas < 14)
            {
                ceki= Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Size biletin qiymeti 10 azn.Apara bileceyiniz ceki 20 kq");
                if (ceki>21)
                {
                    Console.WriteLine("Artiq ceki");
                    double hesab = Convert.ToDouble((ceki - 23) * 0.5);
                }
                else
                {
                    Console.WriteLine("Qeydiyyat ugurlu");
                }
                if (yas>15)
                {
                    ceki=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Sizin biletin qiymeti 15 azn.Apara bileceyiniz ceki 23 kq");
                    if (ceki>24)
                    {
                        double hesab = Convert.ToDouble((ceki-23) * 0.5);
                        Console.WriteLine("Odeyeceyiniz mebleg: "+hesab);
                    }
                    else
                    {
                        Console.WriteLine("Xeta");
                    }
                }
                else
                {
                    Console.WriteLine("Xeta");
                }
            }
            else
            {
                Console.WriteLine("Yas mehdudiyyeti");
            }

        }
       
        else
        {
            Console.WriteLine("Xeta");
        }
        Console.ReadKey();

    }
}