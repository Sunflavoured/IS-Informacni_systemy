﻿string opakovani ="a";

while(opakovani=="a")
{
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("******Generátor (pseudo)náhodných čísel ******");
    Console.WriteLine("************** Tomáš Žižka********************");

    Console.Write("\n\nZadejte počet generovaných čísel (n): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n))
        Console.Write("Nebylo zadáno celé číslo. Zadejte počet čísel znovu: ");

    Console.Write("\nZadejte dolní mez (dm): ");
    int dm;
    while(!int.TryParse(Console.ReadLine(), out dm))
        Console.Write("Nebylo zadáno celé číslo. Zadejte znovu dolní mez:");

    Console.Write("\nZadejte horní mez (hm): ");
    int hm;
    while(!int.TryParse(Console.ReadLine(), out hm))
        Console.Write("Nebylo zadáno celé číslo. Zadejte znovu horní mez:");

    Console.WriteLine("==========================================");
    Console.WriteLine("Zadali jste tyto hodnoty:");
    Console.WriteLine("n = {0}; dm = {1}; hm = {2}",n,dm,hm);
    Console.WriteLine("==========================================");
    
    Random nahodne = new Random();  // příprava pro generátor
    
    int[] pole = new int[n]; //deklarace pole celých čísel o velikosti n prvků
    
    Console.WriteLine("\nGenerovaná (pseudo) náhodná čísla: ");
    int suma = 0;
    for(int i=0;i<n;i++)
    {
        pole[i] = nahodne.Next(dm, hm+1);
        Console.Write("{0}; ",pole[i]);
        suma = suma + pole[i];
    }
    int prumer = suma/n;
    int max=pole[0];
    for(int i=1;i<n;i++)
{
    if(pole[i]>max);
    max=pole[i];
}
    Console.WriteLine("max:{0},prumer:{1}",max, prumer);
    Console.WriteLine("\n\nOpakování programu = stisk klávesy a");
    opakovani = Console.ReadLine();
}