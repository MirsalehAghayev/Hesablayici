using System;

class Hesablayici
{
    public static double HesabIsleri(double sayi1, double sayi2, string op)
    {

        switch (op)
        {
            case "+": return sayi1 + sayi2;
            case "-": return sayi1 - sayi2;
            case "*": return sayi1 * sayi2;
            case "/":

                if (sayi2 != 0)
                {
                    return sayi1 / sayi2;
                }
                else
                {
                    return double.NaN;
                }
            default: return double.NaN;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        bool cixis = false;
        Console.WriteLine("Hesablama sistemi \r");
        Console.WriteLine("------------------------\n");

        while (!cixis)
        {

            string sayi1 = "";
            string sayi2 = "";
            double sonuc = 0;


            Console.Write("Birinci reqemi yazin: ");
            sayi1 = Console.ReadLine();

            double duzgunSayi1 = 0;
            while (!double.TryParse(sayi1, out duzgunSayi1))
            {
                Console.Write("Bu lazimli reqem deyil. Zehmet olmasa tam reqemi yazin.: ");
                sayi1 = Console.ReadLine();
            }


            Console.Write("İkinci reqemi yazin: ");
            sayi2 = Console.ReadLine();

            double duzgunSayi2 = 0;
            while (!double.TryParse(sayi2, out duzgunSayi2))
            {
                Console.Write("Bu lazimli reqem deyil. Zehmet olmasa tam reqemi yazin. ");
                sayi2 = Console.ReadLine();
            }

            
            Console.WriteLine("Zehmet olmasa siyahidan bir emeliyyati secin: ");
            Console.WriteLine("\t+ - Toplama");
            Console.WriteLine("\t- - Çıxma");
            Console.WriteLine("\t* - Vurma");
            Console.WriteLine("\t/ - Bölme");
            Console.Write("Hansini secdiniz? ");

            string op = Console.ReadLine();

            try
            {
                sonuc = Hesablayici.HesabIsleri(duzgunSayi2, duzgunSayi1, op);
                if (double.IsNaN(sonuc))
                {
                    Console.WriteLine("Bu riyazi emeliyyat xetaya sebeb oldu.\n");
                }
                else Console.WriteLine("Cavabiniz: {0:0.##}\n", sonuc);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cavabi hesablayanda bir istisna oldu \n: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

           
            Console.Write(" Proqramdan cixmaq ucun ESC basin. ");
            if (Console.ReadKey().Key == ConsoleKey.Escape) cixis = true;

            Console.WriteLine("\n");
        }
        Console.WriteLine("**Program bitti her hansi bir reqem yazin\n");
        Console.ReadKey();
    }
}