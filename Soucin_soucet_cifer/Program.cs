using System;

class Program
{

    //function to get an int number from user
    static int inputNumber(string request, string error)
    {
        int number;
        Console.WriteLine(request);
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine(error);
        }
        return number;
    }
    static void Main(string[] args)
    {
        string opakovani = "a";
        while (opakovani == "a")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            int number = inputNumber("zadejte celočíselné číslo k výpočtu: ", "Chyba, zadejte znovu: ");

            Console.WriteLine("zadali jste číslo: {0}", number);

            Console.WriteLine("Výpočet součtu a součinu cifer");

            int zbytek = 0;
            int soucet = 0;
            int soucin = 1;
           
            while (number >= 10)
            {

            zbytek = number % 10;
            number = (number - zbytek) / 10;
            soucet = soucet + zbytek;
            soucin = soucin * zbytek;
            }
            soucet = soucet + number;
            soucin = soucin * number;

            Console. BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Součet:{0} \nSoučin:{1}", soucet, soucin);


          
            Console.WriteLine("pro opakování stiskněte a");
            opakovani = Console.ReadLine();
        }

    }
}