using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        string opakovani = "a";

        while (opakovani == "a")
        {
            Console.Clear();
            Console.WriteLine("Vykreslení obdelníku");

            Console.WriteLine("Zadejte celočíslené číslo pro výšku obdelníku: ");
            int hight;
            while (!int.TryParse(Console.ReadLine(), out hight))
            {
                Console.WriteLine("Zadali jste špatnou hodnotu, zadejte znova:");
            }

            Console.WriteLine("Zadejte celočíselnou hodnotu šířky obdelníku: ");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Zadali jste špatnou hodnotu, zadejte znova:");
            }

          Console.WriteLine("zadali jste hodnoty {0} a {1}", hight, width);

            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pro opakování programu stiskněte a");
            opakovani = Console.ReadLine();

        }
        Console.WriteLine("Nashledanou");
    }
}
