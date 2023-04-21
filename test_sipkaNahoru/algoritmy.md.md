```C#
//vypsani max a min hodnot

    int maxHodnota = pole[0];
    int minHodnota = pole[0];
    string poziceMax = "";
    string poziceMin = "";

    for (int i = 0; i < n; i++)
	    {
        if (pole[i] > maxHodnota)
	    {
            maxHodnota = pole[i];
            poziceMax = "" + i;
        }

        else if (pole[i] == maxHodnota)

            poziceMax = poziceMax + "; " + i;

        if (pole[i] < minHodnota)
        {
            minHodnota = pole[i];
            poziceMin = "" + i;
        }
        else if  (pole[i] == minHodnota)
        {poziceMin = poziceMin + "; " + i;}

		suma = suma + pole[i];
    }
```

```C#
//prumer a zbytek

int prumer = suma/n;
int zbytek = suma%n;
```
```C#
//selection sort

    for (int i = 0; i < pole.Length - 1; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < pole.Length; j++)
        {
            if (pole[j] > pole[maxIndex]) maxIndex = j;
        }
        if (maxIndex != 1)
        {
            int pom = pole[i];
            pole[i] = pole[maxIndex];
            pole[maxIndex] = pom;
        }
    }
    Console.WriteLine("\nSeřazení pomocí selection sort:");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", pole[i]);
    }

//insertion sort
	int pocetVymenI=0;
    for (int i = 0; i < pole.Length - 1; i++)
      {
        int j = i + 1;
        int pom = pole[j];
        while (j > 0 && pom > pole[j - 1])
        {
            pole[j] = pole[j - 1];
            j--;
            
        }
        pole[j] = pom;
        pocetVymenI++;
      }
      
      Console.WriteLine("\n\nSeřazené pole (Insertion sort): ");
      
      for(int i=0;i<n;i++)
        Console.Write("{0}; ",pole[i]);




// Bubble sort
using System.Diagnostics;
      Stopwatch stopky = new Stopwatch();
      stopky.Start();
      for(int i=0;i<n-1;i++)
        for(int j=0;j<n-i-1;j++)
          if(pole[j]<pole[j+1])
          {
            int pom = pole[j+1];
            pole[j+1] = pole[j];
            pole[j] = pom;
          }
      
      stopky.Stop();
      
      Console.WriteLine("\n\nSeřazené pole (Bubble sort): ");
      for(int i=0;i<n;i++)
        Console.Write("{0}; ",pole[i]);
		 Console.WriteLine("\n\nČas řazení (Bubble sort): {0}", stopky.Elapsed); 



//comb sort
  bool swapped = false;
        int mezera = n;
        while (mezera != 1 || swapped)
        {
            mezera = (int)(mezera / 1.33);
            swapped = false;
            if (mezera < 1)
            {
                mezera = 1;
            }
            for (int i = 0; i + mezera < pn; i++)
            {
                if (pole[i] < pole[i + mezera])
                {
                    int pom = pole[i];
                    pole[i] = pole[i + mezera];
                    pole[i + mezera] = pom;
                    swapped = true;
                }
            }
        } 
    Console.WriteLine("\nSeřazení pomocí comb sort:");
     for (int i = 0; i < n; i++)
     {
         Console.Write("{0}; ", pole[i]);
     }

//shaker sort
 for (int i = 0; i < n / 2; i++)
    {
        bool vymena = false;
        for (int j = i; j < n - i - 1; j++)
        {
            if (pole[j] < pole[j + 1])
            {
                int pom = pole[j];
                pole[j] = pole[j + 1];
                pole[j + 1] = pom;
                vymena = true;
            }
        }
        for (int j = n - 2 - i; j > i; j--)
        {
            if (pole[j] > pole[j - 1])
            {
                int pom = pole[j];
                pole[j] = pole[j - 1];
                pole[j - 1] = pom;
                vymena = true;
            }
        }
        if (!vymena) break;
    }
    Console.WriteLine("\nSeřazení pomocí shaker sort:");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", pole[i]);
    }

//shell sort

    int mezera = n / 2;
    while (mezera > 0) 
    { 
        for (int i = 0; i < pole.Length - mezera; i++) 
        { 
            int j = i + mezera;
            int tmp = pole[j];
            while (j >= mezera && tmp > pole[j - mezera])
            {
                pole[j] = pole[j - mezera];
                j -= mezera;
            }
            pole[j] = tmp;
        }
        if (mezera == 2) 
        { 
            mezera = 1;
        }
        else
        {
            mezera = (int)(mezera / 2.2);
        }
    }
   Console.WriteLine("\nSeřazení pomocí selection sort:");
     for (int i = 0; i < n; i++)
     {
         Console.Write("{0}; ", pole[i]);
	 }
```

````C#
//hledani 2. a 3. nejvetsiho cisla
int druheNejvetsi = dm;
int tretiNejvetsi = dm;
for(int i=0;i<n;i++)
    {
        if (pole[i] > druheNejvetsi && pole[i] < maxHodnota)
            druheNejvetsi = pole[i];
        if (pole[i] > tretiNejvetsi && pole[i] < druheNejvetsi)
            tretiNejvetsi = pole[i];
    }

//NSD a NSN
long zaloha1 = druheNejvetsi;
long zaloha2 = tretiNejvetsi;
int a = druheNejvetsi;
int b = tretiNejvetsi;

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


//ciferny soucet a soucin
    int a = 45;//cislo s nimz chci pracovat
int cifra;
int suma = 0;
int zaloha = a;
int soucin = 1;
while (a >= 10)
{
    cifra = a % 10;     // modulo % vrátí zbytek po dělení číslem 10    
    a = (a - cifra) / 10;
    suma = suma + cifra;
    soucin = soucin * cifra;
}

suma = suma + a;
soucin = soucin * a;

Console.WriteLine("Součet cifer čísla {0} je {1}", zaloha, suma);
Console.WriteLine("Součin cifer čísla {0} je {1}", zaloha, soucin);

Console.ReadLine();
//analyza textu
Console.Write("\nZadejte vtsupní text: ");
    string text = Console.ReadLine();

    text = text.ToLower();
    Console.WriteLine("\n==========================================");
    Console.WriteLine("Zadaný text převedený na malá písmena: {0}", text);
    Console.WriteLine("==========================================");

    string samohlasky = "aáeéěiíoóuúůyý";
    string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
    string cislice = "0123456789";

    int pocetSamohlasek = 0;
    int pocetSouhlasek = 0;
    int pocetCislic = 0;
    int ch = 0;
    for (int i = 0; i < text.Length; i++)
    {
        char znak = text[i];
        if (znak == 'c' && i < text.Length - 1 && text[i + 1] == 'h')
        {
            pocetSouhlasek++;
            i++;
            ch++;
        }
        else if (souhlasky.Contains(znak))
            pocetSouhlasek++;
        else if (samohlasky.Contains(znak))
            pocetSamohlasek++;
        else if (cislice.Contains(znak))
            pocetCislic++;
    

        Console.WriteLine("\n\nPočet samohlásek: {0}", pocetSamohlasek);
        Console.WriteLine("Počet souhlásek: {0}", pocetSouhlasek);
        Console.WriteLine("Počet číslic: {0}", pocetCislic);
        Console.WriteLine("Počet ostatních znak: {0}", text.Length - pocetSamohlasek - pocetSouhlasek - pocetCislic - ch);

        Console.WriteLine("\nOpakování programu = stisk klávesy a");
        opakovani = Console.ReadLine();
    }
//faktorial 
int cislo = 7
      int  prubezne =cislo;
      
    while(cislo>1)
        {int zaloha = cislo-1;
        prubezne = prubezne * zaloha;
        cislo = zaloha;
        }
      Console.WriteLine("Faktorial: {0}", prubezne);

//prevod z 10 do k soustavy
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

// aritmeticka rada

int pocetPrvku = 12; 
      int[] array = new int[pocetPrvku];
	   //vytvoření pole
      array[0] = 2;
      int diference = 5;
      Console.Write("{0}; ", array[0]);
      for(int i=1;i<12;i++)
      {
		array[i] = array[i-1] + diference;
        Console.Write("{0}; ", array[i]);
	  }

//rovnorameny trojuhelnik
for(int i = 0; i < prumer; i++)
    {
        for(int j = prumer - 1; j > i; j--)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < 2 * i + 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
	}

//obdelnik
for(int i=1; i<=vyska; i++)
        {
        for(int j=1; j <= sirka; j++)                 
            {
            Console.Write("* ");
            }
        Console.WriteLine();
        }