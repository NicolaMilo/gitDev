using System;

class Convertitore
{
    static void Main()
    {
        Console.WriteLine("*La funzione al momento non è disponibile");
        Console.Write("1) Decimale - Binario\n2) Decimale - Esadecimale\n3) Decimale - Ottale\n4) Binario - Decimale\n5) Esadecimale - Decimale\n6) Ottale - Decimale\nNumero: ");
        string scelta = Console.ReadLine();

        switch (scelta)
        {
            case "1":
                decBin();
                break;

            case "2":
                decHex();
                break;

            case "3":
                decOct();
                break;

            case "4":
                binDec();
                break;

            case "5":
                hexDec();
                break;

            case "6":
                octDec();
                break;

            default:
                Console.WriteLine("This is the default selection because you've selected an invald character");
                break;
        }

        Console.ReadKey(true);
    }

    static void decBin()
    {
        int intValue = 0;
        
        try
        {
            Console.Write("\n\nInserisci il valore decimale: ");
            intValue = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("An error has occured, retry!");
            decBin();
        }
        Console.WriteLine("Il valore " + intValue + " in binario è " + Convert.ToString(intValue, 2));
    }

    static void decHex()
    {
        int intValue = 0;

        try
        {
            Console.Write("\n\nInserisci il valore decimale: ");
            intValue = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("An error has occured, retry!");
            decHex();
        }
        Console.WriteLine("Il valore " + intValue + " in esadecimale è " + Convert.ToString(intValue, 16));
    }

    static void decOct()
    {
        int intValue = 0;

        try
        {
            Console.Write("\n\nInserisci il valore decimale: ");
            intValue = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("An error has occured, retry!");
            decOct();
        }
        Console.WriteLine("Il valore " + intValue + " in ottale è " + Convert.ToString(intValue, 8));
    }

    static void binDec()
    {
        string binValue = "";

        try
        {
            binValue = Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("An error has occured, retry!");
            binDec();
        }         
        Console.WriteLine("Il valore binario " + binValue + " in decimale è " + Convert.ToInt32(binValue, 2));
    }

    static void hexDec()
    {
        string hexValue = "";

        try
        {
            Console.Write("\n\nInserisci il valore esadecimale: ");
            hexValue = Console.ReadLine().ToUpper();
        }
        catch
        {
            Console.WriteLine("An error has occured, retry!");
            hexDec();
        }
        Console.WriteLine("Il valore ottale " + hexValue + " in decimale è " + Convert.ToInt32(hexValue, 16));
    }

    static void octDec()
    {
        string octValue = "";

        try
        {
            Console.Write("\n\nInserisci il valore ottale: ");
            octValue = Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("An error has occured, retry!");
            octDec();
        }
        Console.WriteLine("Il valore ottale " + octValue + " in decimale è " + Convert.ToInt32(octValue, 8));
    }
}
