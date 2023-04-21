using System.Diagnostics;
string opakovani = "a";

while (opakovani == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("******Generátor (pseudo)náhodných čísel ******");
    Console.WriteLine("************** Tomáš Žižka********************");

    Console.Write("\n\nZadejte počet generovaných čísel (n): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
        Console.Write("Nebylo zadáno celé číslo. Zadejte počet čísel znovu: ");

    Console.Write("\nZadejte dolní mez (dm): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
        Console.Write("Nebylo zadáno celé číslo. Zadejte znovu dolní mez:");

    Console.Write("\nZadejte horní mez (hm): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm))
        Console.Write("Nebylo zadáno celé číslo. Zadejte znovu horní mez:");

    Console.WriteLine("==========================================");
    Console.WriteLine("Zadali jste tyto hodnoty:");
    Console.WriteLine("n = {0}; dm = {1}; hm = {2}", n, dm, hm);
    Console.WriteLine("==========================================");

    Random nahodne = new Random();  // příprava pro generátor
    int[] pole = new int[n]; //deklarace pole celých čísel o velikosti n prvků

    for (int i = 0; i < n; i++)
    {
        pole[i] = nahodne.Next(dm, hm + 1);
        Console.Write("{0}; ", pole[i]);
    }

    //vypsani max a min hodnot a jejich pozic
    int maxHodnota = pole[0];
    int minHodnota = pole[0];
    string poziceMax = "";
    string poziceMin = "";
    int suma = 0;

    for (int i = 0; i < n; i++)
    {
        if (pole[i] > maxHodnota)
        {
            maxHodnota = pole[i];
            poziceMax = "" + i;
        }
        else if (pole[i] == maxHodnota)
        { poziceMax = poziceMax + "; " + i; }

        if (pole[i] < minHodnota)
        {
            minHodnota = pole[i];
            poziceMin = "" + i;
        }
        else if (pole[i] == minHodnota)
        { poziceMin = poziceMin + "; " + i; }

        suma = suma + pole[i];
    }

    Console.WriteLine("\n\nmaximalni hodnota: {0} \nPozice max: {1}", maxHodnota, poziceMax);
    Console.WriteLine("\nminimalni hodnota: {0} \nPozice min: {1}", minHodnota, poziceMin);
    //prumer a zbytek

    int prumer = suma / n;
    int zbytek = suma % n;
    Console.WriteLine("suma: {0}", suma);
    Console.WriteLine("Prumer: {0}, zbytek: {1}", prumer, zbytek);

    // hledani druheho max a tretiho max
    
    

    //selection sort
    for (int i = 0; i < n; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (pole[maxIndex] < pole[j])
            {
                maxIndex = j;
            }
        }
        if (i != maxIndex)
        {
            int num = pole[i];
            pole[i] = pole[maxIndex];
            pole[maxIndex] = num;
        }
       }
    Console.WriteLine("\nSeřazení pomocí selection sort:");
     for (int i = 0; i < n; i++)
     {
         Console.Write("{0}; ", pole[i]);
     }

//hledani 2. nejvetsiho a 3. nejmensiho cisla
    int druheNejvetsi = dm;
    int tretiNejvetsi = dm;
    for(int i=0;i<n;i++)
    {
        if (pole[i] > druheNejvetsi && pole[i] < maxHodnota)
            druheNejvetsi = pole[i];
        if (pole[i] > tretiNejvetsi && pole[i] < druheNejvetsi)
            tretiNejvetsi = pole[i];
    }
 Console.WriteLine("\n\nDruhé největší číslo: {0}\nTřetí největší číslo: {1}", druheNejvetsi, tretiNejvetsi);

//NSD a NSN
long zaloha1=druheNejvetsi;
long zaloha2 =tretiNejvetsi;
int a = druheNejvetsi;
int b =tretiNejvetsi;

while(a != b)
{
    if(a > b)
    {
        a = a-b;  
    }
    if(a < b)
    b = b - a;
}
      long NSD = a;
      long NSN = (zaloha1*zaloha2) / NSD;
  
      Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}",zaloha1, zaloha2, NSD);
      Console.WriteLine("\n\nNSN čísel {0} a {1} je {2}",zaloha1, zaloha2, NSN);    

//faktorial prumeru
       int cislo = prumer;
      int  vysledek =cislo;
      
    while(cislo>1)
        {int zaloha = cislo-1;
        vysledek = vysledek * zaloha;
        cislo = zaloha;
         }
      Console.WriteLine("Faktorial: {0}", vysledek);  

//prevod
int[] pole1 = new int[20];
int prevadeneCislo = prumer;
int zbytek1 = 0;
int s;
for(s=0;prevadeneCislo>0;s++)
    {
        zbytek1 = prevadeneCislo % 2;
        prevadeneCislo = (prevadeneCislo - zbytek1) / 2;
        pole[s]=zbytek1;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.WriteLine("Celá část = {0}, zbytek = {1}", prevadeneCislo, zbytek1);
        
    }
      Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\n\nVýsledek: ");
    for(int j=s-1;j>=0;j--)
        Console.Write("{0}",pole[j]);
      
   
    
//šipka, vyska jednotlivych casti je prumer generovanych cisel

//horni cast šipky

  for(int i = 0; i < prumer; i++)
    {
        for(int j = prumer - 1; j > i; j--)
        {
            Console.Write("  ");
        }
        for (int k = 0; k < 2 * i + 1; k++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
//dolni cast sipky
for (int i = 0; i < prumer - 1; i++)
        {
            for (int j = 0; j < prumer-2; j++)
            {
                Console.Write("  ");
            }
            for(int l = 0; l < 3;l++)
          {
            Console.Write("* ");
          }
        Console.WriteLine();
        }


 


Console.WriteLine("\n\nOpakování programu = stisk klávesy a");
opakovani = Console.ReadLine();
}


