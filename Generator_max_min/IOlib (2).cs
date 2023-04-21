using System;

class IOlib
{
    public static int inputNumber(string request, string error)
    {
        int number;
        Console.WriteLine(request);
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine(error);
        }
        return number;
    }

    //Vykreslení pravouhlého trojuhelníku
    public static void print_triangle(int hight)
    {
        for (int i = 0; i < hight; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine(" *");
        }
        Console.WriteLine();
    }

    //vykreslení rovnoramenného trojuhelníku
    public static void print_rovnorameny(int hight, int shift)
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

    public static void print_n_chars(int n, string s)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(s);
        }
    }

    public static void print_tree(int tree_size, int trunk_width)
    {
        // koruna
        for (int i = 0; i < tree_size; i++)
        {
            IOlib.print_rovnorameny(i + 1, tree_size - i - 1);
        }
        // kmen
        for (int i = 0; i < tree_size / 2; i++)
        {
            print_n_chars(tree_size - trunk_width / 2 - 1, " ");
            print_n_chars(trunk_width, "*");
            /*
			for (int i = 0; i < tree_size - trunk_width / 2 - 1; i++)
        	{
	            Console.Write(" ");
	        }
			for (int i = 0; i < trunk_width; i++)
	        {
	            Console.Write("*");
	        }
			*/
            Console.WriteLine();
        }
    }
}
