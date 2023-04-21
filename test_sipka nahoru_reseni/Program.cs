
string pokracovani = "a";

static int nsd(int a, int b)
{
    int vysledek;

    if (a == 0)
    {
        vysledek = b;
    }
    else if (b == 0)
    {
        vysledek = a;
    }
    else
    {
        vysledek = nsd(b, a % b);
    }
    return vysledek;
}

static int nsn(int a, int b)
{
    int vysledek;

    if (a == 0)
    {
        vysledek = b;
    }
    else if (b == 0)
    {
        vysledek = a;
    }
    else
    {
        vysledek = (a * b) / nsd(a, b);
    }
    return vysledek;
}

while (pokracovani == "a")
{
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("************* Zápočtový test *************");
    Console.WriteLine("******************************************");

    Console.Write("\n\nZadejte počet generovaných čísel (n): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
        Console.Write("Počet čísel musí být celočíselný. Zadejte ho znovu: ");

    Console.Write("Zadejte dolní mez intervalu (dm): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
        Console.Write("Dolní mez musí být celočíselná. Zadejte ji znovu: ");

    Console.Write("Zadejte horní mez intervalu (hm): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm))
        Console.Write("Horní mez musí být celočíselná. Zadejte ji znovu: ");

    Console.WriteLine("\n============================================================");
    Console.WriteLine("Zadali jste tyto hodnoty: ");
    Console.WriteLine("n = {0}; dm = {1}; hm = {2}", n, dm, hm);
    Console.WriteLine("===============================================================");

    Random nahodne = new Random();
    int[] pole = new int[n];
    int maximum = dm, minimum = hm + 1;
    int druheNejvetsi = maximum, tretiNejvetsi = maximum;
    string maximaPozice = "", minimaPozice = "";
    int prumer, zbytek, suma = 0;

    Console.WriteLine("\nGeneruji tato (pseudo)náhodná čísla: ");

    for (int i = 0; i < n; i++)
    {
        pole[i] = nahodne.Next(dm, hm + 1);
        if (pole[i] > maximum)
        {
            maximum = pole[i];
            maximaPozice = "" + i;
        }
        else if (pole[i] == maximum)
            maximaPozice += "; " + i;

        if (pole[i] < minimum)
        {
            minimum = pole[i];
            minimaPozice = "" + i;
        }
        else if (pole[i] == minimum)
            minimaPozice += "; " + i;

        suma += pole[i];
        Console.Write("{0}; ", pole[i]);
    }

    Console.WriteLine("\n\nMaximu: {0}, všechny pozice maxima: {1}", maximum, maximaPozice);
    Console.WriteLine("\nMinimu: {0}, všechny pozice minima: {1}", minimum, minimaPozice);

    for (int i = 0; i < n; i++)
    {
        int maximumPozice = i;
        for (int j = i + 1; j < n; j++)
        {
            if (pole[maximumPozice] < pole[j])
            {
                maximumPozice = j;
            }
        }
        if (i != maximumPozice)
        {
            int num = pole[i];
            pole[i] = pole[maximumPozice];
            pole[maximumPozice] = num;
        }

        if (pole[i] > druheNejvetsi && pole[i] < maximum)
            druheNejvetsi = pole[i];
        if (pole[i] > tretiNejvetsi && pole[i] < druheNejvetsi)
            tretiNejvetsi = pole[i];
    }

    Console.WriteLine("\nSeřazení pomocí selection sort:");
    Console.Write("\n{0}", pole[0]);
    for (int i = 1; i < n; i++)
    {
        Console.Write(", {0}", pole[i]);
    }

    prumer = suma / n;
    zbytek = suma % n;
    Console.WriteLine("\n\nDruhé největší číslo: {0}\nTřetí největší číslo: {1}", druheNejvetsi, tretiNejvetsi);
    Console.WriteLine("\nPrůměr generovaných čísel: celá část: {0}, zbytek: {1}", prumer, zbytek);

    Console.WriteLine("\nNejmenší společný násobek (NSN) čísel {0} a {1} je: {2}", druheNejvetsi, tretiNejvetsi, nsn(druheNejvetsi, tretiNejvetsi));
    Console.WriteLine("\nNejvětší společný dělitel (NSD) čísel {0} a {1} je: {2}", druheNejvetsi, tretiNejvetsi, nsd(druheNejvetsi, tretiNejvetsi));

    int sirkaObdelniku = 1, odsazeni = 0;

    Console.WriteLine("\n\nŠipka:\n");
    for (int i = 0; i < prumer; i++)
    {
        if (i == 1)
        {
            sirkaObdelniku = i * 2 + 1;
            odsazeni = prumer - i - 1;
        }
        for (int j = 0; j < prumer - i - 1; j++)
        {
            Console.Write("  ");
        }
        for (int j = 0; j < (i * 2) + 1; j++)
        {
            if (i > 1 && j == (prumer - (prumer - i - 1) - 1))
                Console.Write("  ");
            else
                Console.Write("* ");
        }
        Console.Write("\n");
    }

    for (int i = 0; i < prumer; i++)
    {
        for (int j = 0; j < odsazeni; j++)
        {
            Console.Write("  ");
        }
        for (int j = 0; j < sirkaObdelniku; j++)
        {
            if (i == prumer - 1 || j == 0 || j == sirkaObdelniku - 1)
                Console.Write("* ");
            else
                Console.Write("  ");
        }
        Console.Write("\n");
    }

    Console.Write("\n\nPro pokračování stiskněte a, pro ukončení cokoliv jiného: ");
    pokracovani = Console.ReadLine();
}