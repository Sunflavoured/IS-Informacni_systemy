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

/*Vykreslení pravouhlého trojuhelníku



{
    int hight = inputNumber("Zadejte výšku", "Zadejte znovu");
    Console.WriteLine("zadali jste výšku: {0}", hight);

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(" *");
        }

        Console.WriteLine(" *");
    }

}*/

//vykreslení rovnoramenného trojuhelníku




{
    int hight = inputNumber("Zadejte výšku", "Zadejte znovu");
    Console.WriteLine("zadali jste výšku: {0}", hight);

    for(int i = 0; i < hight; i++)
    {
        for(int j = hight - 1; j > i; j--)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < 2 * i + 1; k++)
        {
            Console.Write("*");
        }

        // 2*i+1
        /*
        for (int k = 0; k < i; k++)
        {
            Console.Write("*");
        }
        Console.Write("*");
        for (int k = 0; k < i; k++)
        {
            Console.Write("*");
        }*/

        Console.WriteLine();
    }
}

Console.ReadLine();
