using System.IO;
namespace Huto_feladat;

class Program
{
    private static List<string> tartalom = new List<string>();

    static void Listazas()
    {
        Console.WriteLine("A hűtő tartalma:");
        foreach (var item in tartalom)
        {
            Console.WriteLine(item.ToLower());
        }
    }

    static void Feltoltes()
    {
        string valasz;
        do
        {
            Console.WriteLine("Milyen ételt szeretne hozzáadni");
            valasz = Console.ReadLine();
            if (valasz != "")
            {
                tartalom.Add(valasz);
            }
        } while (valasz != "");
    }

    static void Kiszedes()
    {
        Console.WriteLine("Milyen ételt akkarsz kivenni?");
        string valasz = Console.ReadLine();
        if (tartalom.Contains(valasz))
        {
            tartalom.Remove(valasz);
        }
    }

    static void FaljbaIras()
    {
        
        StreamWriter sw = new StreamWriter("Tartalom.txt");
        foreach (var item in tartalom)
        {
            string s = $"{item}\n";
            sw.Write(s);
        }
        sw.Close();
    }

    static void FaljbaOlvasas()
    {
        StreamReader sr = new StreamReader("Tartalom.txt");
        while (!sr.EndOfStream)
        {
            tartalom.Add(sr.ReadLine());
        }
        sr.Close();
    }
    
    static void Main(string[] args)
    {

        char valasz;
        do
        {
            Console.WriteLine("|--------------------------------------------------------|");
            Console.WriteLine("Menu: \n\t1. listázás: \n\t2. Étel berakása a hűtőbe \n\t3. Étel kivétele \n\t4. Hütő importálása \n\t5. Hütő exportálás \n\t6. Kilépés");
            valasz = Console.ReadLine()[0];
            switch (valasz)
            {
                case '1':
                    Listazas();
                    break;
                case '2':
                    Feltoltes();
                    break;
                case '3':
                    
                    break;
                case '4':
                    FaljbaOlvasas();
                    break;
                case '5':
                    FaljbaIras();
                    break;
                case '6':
                    Console.WriteLine("Viszlát");
                    break;
            }
            Console.WriteLine("|--------------------------------------------------------|");
        } while (valasz != '6');


    }
}