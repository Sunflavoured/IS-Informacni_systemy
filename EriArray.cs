using System;

class EriArray
{
    public static int[] fillWithRandomInt(int len, int min, int max)
    {
        Random nahodne = new Random();
        int[] pole = new int[len];
        for (int i = 0; i < len; i++)
        {
            pole[i] = nahodne.Next(min, max + 1);
        }
        return pole;
    }

    public static int sum(int[] arr)
    {
        int suma = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            suma += arr[i];
        }
        return suma;
    }

    public static void print(int[] arr, int len)
    {
        for (int i = 0; i < len; i++)
        {
            Console.Write("{0}; ", arr[i]);
        }
    }
	
    // TODO:
    // print(int[] arr, int len) // za pouziti foreach

    // avg(int[] arr, int len)
    // ToString((int[] arr, int len)
}
