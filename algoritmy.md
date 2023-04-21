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

//reverze pole
Random nahodne = new Random();  // příprava pro generátor
    
    int[] pole = new int[n]; //deklarace pole celých čísel o velikosti n prvků
    
    Console.WriteLine("\nGenerovaná (pseudo) náhodná čísla: ");

    for(int i=0;i<n;i++)
    {
        pole[i] = nahodne.Next(dm, hm+1);
        Console.Write("{0}; ",pole[i]);
    }

    for(int i=0;i<n/2;i++)
    {
        int pom = pole[i];
        pole[i] = pole[n-i-1];
        pole[n-i-1] = pom;
    }

    Console.WriteLine("\n\nPole po reverzi: ");
    for(int i=0;i<n;i++)
    {
        Console.Write("{0}; ",pole[i]);
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
    int cifra;
    int suma = 0;
    int zaloha = a;
    int soucin = 1;

    while(a>=10) {
        cifra = a % 10;     // modulo % vrátí zbytek po dělení číslem 10    
        a = (a - cifra)/10;
        suma = suma + cifra;
        soucin = soucin * cifra;
    }

    suma = suma + a;
    soucin = soucin * a;

    Console.WriteLine("Součet cifer čísla {0} je {1}",zaloha,suma);
    Console.WriteLine("Součin cifer čísla {0} je {1}",zaloha,soucin);
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
//kvadraticka rovnice

double d = b*b-4*a*c;
Console.WriteLine($"{d}");
if(d<0)
{
    Console.WriteLine("Rovnice nemá v oboru reálných čísel řešení");
}
else if (d==0)
{
    double m = -b / 2 * a;
    Console.WriteLine($"{m}");
}
else
{
    double g = (-b + Math.Sqrt(d)) / (2 * a);
    double h = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine($"{g}");
    Console.WriteLine($"{h}");
}

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
//pravouhly trojuhelnik
int vyska = 5; 
for(int i=1;i<=vyska;i++) {
        for(int j=1;j<=i;j++)  { 
            Console.Write("* ");
        }
        Console.WriteLine();
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
//obraceny rovnorameny trojuhelnik
int vyska = 5; //vyska
    for (int i = 0; i < vyska; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("  ");

        }
        for (int k = vyska * 2 - 1; k >= 2 * i + 1; k--)
        {
            Console.Write("* ");
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
//stromecek
static void print_rovnorameny(int hight, int shift)
    {
        for (int i = 0; i < hight; i++)
        {
            for (int j = hight + shift - 1; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    int prumer = 10;
    int pulkaPrumeru = prumer / 2;
            int trunk_width = 5;

            for (int i = 0; i < prumer; i++)
            {
               print_rovnorameny(i + 1, prumer - i -1);
            }
            int tree_size = prumer;
            for (int i = 0; i < pulkaPrumeru; i++)
            {
                for (int k = 0; k < tree_size - trunk_width / 2 - 1; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < trunk_width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
//sipka nahoru
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
//obraceny pravouhly trojuhelnik
int vyska = 5;  
int i, j, k ;  
for (i = 1; i <= vyska; i++)  
    {  
         for (j = 1; j <= vyska-i; j++)  
        {  
            Console.Write(" ");  
        }  
        for (k = 1; k <= i; k++)  
        {  
            Console.Write("*");  
        }  
        Console.WriteLine("");  
    }  
//pravouhly vzhuru nohama 
int val = 5;  
int i, j, k ;  
for (i = 1; i <= val; i++)  
         {  
            for (j = 1; j <= val-i; j++)   
            for (k = 1; k <= j; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
         Console.ReadLine();  
//pascaluv trojuhelnik
int rows;
Console.WriteLine("Zadejte počet řádků:");
while (!int.TryParse(Console.ReadLine(), out rows))
{
    Console.WriteLine("Zadejte znovu");
}
int cislo = 1, odsazeni, i, j;
Console.WriteLine("Pacalův trojuhelník");
for (i = 0; i < rows; i++)
{
    for (odsazeni = 1; odsazeni <= rows - i; odsazeni++)
        Console.Write(" ");
    for (j = 0; j <= i; j++)
    {
        if (j == 0 || i == 0)
            cislo = 1;
        else
            cislo = cislo * (i - j + 1) / j;
        Console.Write(cislo + " ");
    }
    Console.WriteLine();
}
Console.ReadLine();