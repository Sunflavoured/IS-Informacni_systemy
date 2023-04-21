{
    Console.Clear();
    Console.WriteLine("Vykreslení trojuhelniku");
    Console.WriteLine("Zadejte výšku trojuhelníku: ");
    int hight = 0;
    while (!int.TryParse(Console.ReadLine(), out hight))
        Console.WriteLine("Zadejte výšku znovu: ");

    for(int i=0;i<hight;i++)
    {
        for(int j=0;j<i;j++)
    {Console.Write(" *");
    }
    Console.WriteLine(" *");
    }
Console.ReadLine();



}